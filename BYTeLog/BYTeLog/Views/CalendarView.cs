using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BYTeLog.Views
{
    public partial class CalendarView : UserControl
    {
        private DateTime _currentMonth;
        private string _currentView = "month";

        private static readonly Color ColActivity = Color.FromArgb(58, 99, 232);
        private static readonly Color ColAttendance = Color.FromArgb(16, 163, 92);
        private static readonly Color ColMembership = Color.FromArgb(130, 60, 220);
        private static readonly Color ColPenalty = Color.FromArgb(220, 60, 60);
        private static readonly Color ColClearance = Color.FromArgb(234, 140, 30);
        private static readonly Color ColCheckpoint = Color.FromArgb(0, 172, 193);

        private List<CalendarEvent> _events = new();

        public CalendarView()
        {
            InitializeComponent();
            _currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            LoadSampleEvents();
            RenderCalendar();
        }

        private void LoadSampleEvents()
        {
            var today = DateTime.Today;
            _events = new List<CalendarEvent>
            {
                // Sample Data (Feel free to remove) :D
                new() { Date = today,              Title = "General Assembly",          Type = "Activity",   Module = "Activity",   Status = "Upcoming",  Time = "2:00 PM", Location = "Gymnasium", Description = "Bruh1" },
                new() { Date = today.AddDays(3),   Title = "Membership Fee Deadline",   Type = "Membership", Module = "Membership", Status = "Upcoming",  Time = "11:59 PM", Location = "—", Description = "Bruh2" },
                new() { Date = today.AddDays(5),   Title = "Attendance Check",          Type = "Attendance", Module = "Attendance", Status = "Upcoming",  Time = "7:00 AM", Location = "CIS Lobby", Description = "Bruh3" },
                new() { Date = today.AddDays(7),   Title = "Penalty Payment Due",       Type = "Penalty",    Module = "Penalty",    Status = "Upcoming",  Time = "5:00 PM", Location = "—", Description = "Bruh4" },
                new() { Date = today.AddDays(10),  Title = "Clearance Processing",      Type = "Clearance",  Module = "Clearance",  Status = "Upcoming",  Time = "9:00 AM", Location = "CIS 305", Description = "Bruh5" },
                new() { Date = today.AddDays(12),  Title = "Activity Checkpoint",       Type = "Checkpoint", Module = "Checkpoint", Status = "Upcoming",  Time = "3:00 PM", Location = "CIS 203", Description = "Bruh6" },
                new() { Date = today.AddDays(-3),  Title = "Past Meeting",              Type = "Activity",   Module = "Activity",   Status = "Completed", Time = "1:00 PM", Location = "CIS 303", Description = "Bruh7" },
                new() { Date = today.AddDays(-7),  Title = "Mem. Payment Received",     Type = "Membership", Module = "Membership", Status = "Completed", Time = "All Day",  Location = "—", Description = "Bruh8" },
                new() { Date = today.AddDays(14),  Title = "Officer Committee Meeting", Type = "Activity",   Module = "Activity",   Status = "Upcoming",  Time = "4:00 PM", Location = "CIS 305", Description = "Bruh9" },
                new() { Date = today.AddDays(18),  Title = "2nd Checkpoint",            Type = "Checkpoint", Module = "Checkpoint", Status = "Upcoming",  Time = "2:00 PM", Location = "CIS 105", Description = "Bruh10" },
            };
        }

        private void RenderCalendar()
        {
            lblMonthYear.Text = _currentMonth.ToString("MMMM yyyy");
            switch (_currentView)
            {
                case "week": RenderWeekView(); break;
                case "list": RenderListView(); break;
                default: RenderMonthView(); break;
            }
        }

        private void RenderMonthView()
        {
            pnlCalendarCells.Controls.Clear();
            pnlCalendarCells.Visible = true;
            pnlDayHeaders.Visible = true;
            dividerDayHeader.Visible = true;

            int cellW = 838 / 7;
            int cellH = 103;

            var startDate = _currentMonth.AddDays(-(int)_currentMonth.DayOfWeek);

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    var cellDate = startDate.AddDays(row * 7 + col);
                    var cell = BuildDayCell(cellDate, col, row, cellW, cellH);
                    pnlCalendarCells.Controls.Add(cell);
                }
            }
        }

        private Panel BuildDayCell(DateTime date, int col, int row, int cellW, int cellH)
        {
            bool isCurrentMonth = date.Month == _currentMonth.Month;
            bool isToday = date.Date == DateTime.Today;

            var cell = new Panel
            {
                Location = new Point(col * cellW, row * cellH),
                Size = new Size(cellW, cellH),
                BackColor = isToday ? Color.FromArgb(245, 248, 255) : Color.White,
                Cursor = Cursors.Hand,
                Tag = date,
                Name = $"cell_{date:yyyyMMdd}"
            };

            cell.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(236, 230, 222), 1);
                e.Graphics.DrawLine(pen, cellW - 1, 0, cellW - 1, cellH - 1);
                e.Graphics.DrawLine(pen, 0, cellH - 1, cellW - 1, cellH - 1);

                if (isToday)
                {
                    using var todayPen = new Pen(Color.FromArgb(58, 99, 232), 2);
                    e.Graphics.DrawLine(todayPen, 0, 0, cellW, 0);
                }
            };

            var lblDay = new Label
            {
                AutoSize = false,
                Text = date.Day.ToString(),
                Font = new Font("Poppins", 8.5F, isToday ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = isToday
                    ? Color.FromArgb(58, 99, 232)
                    : isCurrentMonth
                        ? Color.FromArgb(20, 20, 20)
                        : Color.FromArgb(190, 185, 178),
                Location = new Point(6, 4),
                Size = new Size(cellW - 12, 22),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            if (isToday)
            {
                lblDay.BackColor = Color.FromArgb(58, 99, 232);
                lblDay.ForeColor = Color.White;
                lblDay.Size = new Size(24, 22);
                lblDay.TextAlign = ContentAlignment.MiddleCenter;
            }

            cell.Controls.Add(lblDay);

            var dayEvents = _events.Where(e => e.Date.Date == date.Date).ToList();
            int chipY = 30;
            int shown = 0;

            foreach (var ev in dayEvents)
            {
                if (shown >= 3) break;

                var chip = new Label
                {
                    AutoSize = false,
                    Text = ev.Title,
                    Font = new Font("Poppins", 6.5F, FontStyle.Bold),
                    BackColor = GetEventColor(ev.Type),
                    ForeColor = Color.White,
                    Location = new Point(4, chipY),
                    Size = new Size(cellW - 10, 16),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(3, 0, 0, 0),
                    Cursor = Cursors.Hand,
                    Tag = ev
                };
                chip.Click += EventChip_Click;
                cell.Controls.Add(chip);
                chipY += 19;
                shown++;
            }

            int extra = dayEvents.Count - shown;
            if (extra > 0)
            {
                cell.Controls.Add(new Label
                {
                    AutoSize = false,
                    Text = $"+{extra} more",
                    Font = new Font("Poppins", 6.5F),
                    ForeColor = Color.FromArgb(122, 122, 128),
                    Location = new Point(6, chipY),
                    Size = new Size(cellW - 12, 14),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Transparent
                });
            }

            cell.Click += DayCell_Click;
            return cell;
        }

        private void RenderWeekView()
        {
            pnlCalendarCells.Controls.Clear();

            var weekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            int cellW = 838 / 7;

            for (int d = 0; d < 7; d++)
            {
                var date = weekStart.AddDays(d);
                var weekCell = BuildDayCell(date, d, 0, cellW, 600);
                weekCell.Size = new Size(cellW, 600);
                pnlCalendarCells.Controls.Add(weekCell);
            }
        }

        private void RenderListView()
        {
            pnlCalendarCells.Controls.Clear();
            pnlDayHeaders.Visible = false;
            dividerDayHeader.Visible = false;

            var upcoming = _events
                .Where(e => e.Date.Date >= DateTime.Today)
                .OrderBy(e => e.Date)
                .ToList();

            int y = 4;
            foreach (var ev in upcoming)
            {
                var row = BuildListRow(ev, y);
                pnlCalendarCells.Controls.Add(row);
                y += 56;
            }

            if (!upcoming.Any())
            {
                pnlCalendarCells.Controls.Add(new Label
                {
                    Text = "No upcoming events for this period.",
                    Font = new Font("Poppins", 9F),
                    ForeColor = Color.FromArgb(170, 165, 158),
                    Location = new Point(280, 260),
                    AutoSize = true
                });
            }
        }

        private Panel BuildListRow(CalendarEvent ev, int y)
        {
            var pnl = new Panel
            {
                BackColor = Color.FromArgb(250, 250, 252),
                Location = new Point(0, y),
                Size = new Size(838, 48),
                Cursor = Cursors.Hand,
                Tag = ev
            };

            var accent = new Panel
            {
                BackColor = GetEventColor(ev.Type),
                Location = new Point(0, 0),
                Size = new Size(4, 48)
            };

            var lblDate = new Label
            {
                AutoSize = false,
                Text = ev.Date.ToString("MMM dd, yyyy"),
                Font = new Font("Poppins", 8F, FontStyle.Bold),
                ForeColor = Color.FromArgb(122, 122, 128),
                Location = new Point(14, 0),
                Size = new Size(140, 48),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblTime = new Label
            {
                AutoSize = false,
                Text = ev.Time,
                Font = new Font("Poppins", 8F),
                ForeColor = Color.FromArgb(122, 122, 128),
                Location = new Point(160, 0),
                Size = new Size(90, 48),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblTitle = new Label
            {
                AutoSize = false,
                Text = ev.Title,
                Font = new Font("Poppins", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 20, 20),
                Location = new Point(258, 0),
                Size = new Size(340, 48),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var badge = new Label
            {
                AutoSize = false,
                Text = ev.Type,
                Font = new Font("Poppins", 7.5F, FontStyle.Bold),
                ForeColor = GetEventColor(ev.Type),
                BackColor = GetEventBgColor(ev.Type),
                Location = new Point(606, 12),
                Size = new Size(90, 24),
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(4, 0, 4, 0)
            };

            pnl.Controls.AddRange(new Control[] { accent, lblDate, lblTime, lblTitle, badge });
            pnl.Click += (s, e) => ShowEventDetail((CalendarEvent)pnl.Tag!);
            return pnl;
        }

        private void ShowEventDetail(CalendarEvent ev)
        {
            var col = GetEventColor(ev.Type);
            var bg = GetEventBgColor(ev.Type);

            pnlEventDetailAccentBar.BackColor = col;
            lblEdTypeBadge.Text = ev.Type;
            lblEdTypeBadge.ForeColor = col;
            lblEdTypeBadge.BackColor = bg;
            lblEdEventName.Text = ev.Title;
            lblEdDate.Text = ev.Date.ToString("dddd, MMMM d, yyyy");
            lblEdTime.Text = ev.Time;
            lblEdModule.Text = ev.Module;
            lblEdStatus.Text = ev.Status;
            lblEdLocation.Text = string.IsNullOrWhiteSpace(ev.Location) ? "—" : ev.Location;
            txtEdDesc.Text = ev.Description ?? "(No description provided.)";

            cardEventDetail.Visible = true;

            outerScrollPanel.ScrollControlIntoView(cardEventDetail);
        }

        private static Color GetEventColor(string type) => type switch
        {
            "Activity" => ColActivity,
            "Attendance" => ColAttendance,
            "Membership" => ColMembership,
            "Penalty" => ColPenalty,
            "Clearance" => ColClearance,
            "Checkpoint" => ColCheckpoint,
            _ => Color.FromArgb(122, 122, 128)
        };

        private static Color GetEventBgColor(string type) => type switch
        {
            "Activity" => Color.FromArgb(233, 239, 255),
            "Attendance" => Color.FromArgb(230, 255, 242),
            "Membership" => Color.FromArgb(243, 230, 255),
            "Penalty" => Color.FromArgb(255, 237, 237),
            "Clearance" => Color.FromArgb(255, 243, 230),
            "Checkpoint" => Color.FromArgb(225, 248, 252),
            _ => Color.FromArgb(240, 240, 240)
        };

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(-1);
            RenderCalendar();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(1);
            RenderCalendar();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            _currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            RenderCalendar();
        }

        private void btnViewToggle_Click(object sender, EventArgs e)
        {
            if (sender is not IconButton btn) return;
            _currentView = btn.Tag?.ToString() ?? "month";

            foreach (Control c in cardNavBar.Controls)
            {
                if (c is not IconButton ib || ib.Tag is null) continue;
                bool active = ib.Tag.ToString() == _currentView;
                ib.BackColor = active ? Color.FromArgb(58, 99, 232) : Color.White;
                ib.ForeColor = active ? Color.White : Color.FromArgb(122, 122, 128);
                ib.IconColor = active ? Color.White : Color.FromArgb(122, 122, 128);
                ib.FlatAppearance.BorderSize = active ? 0 : 1;
            }

            RenderCalendar();
        }

        private void DayCell_Click(object sender, EventArgs e)
        {
            // TODO: Optionally filter upcoming list to the clicked date
        }

        private void EventChip_Click(object sender, EventArgs e)
        {
            if (sender is Label chip && chip.Tag is CalendarEvent ev)
                ShowEventDetail(ev);
        }

        private void UpcomingItem_Click(object? sender, EventArgs e)
        {
            // TODO: Upcoming panels forward click to ShowEventDetail via Tag
        }

        private void btnCloseEventDetail_Click(object sender, EventArgs e)
        {
            cardEventDetail.Visible = false;
        }

        private void btnEdViewRecord_Click(object sender, EventArgs e)
        {
            // TODO: Navigate to the relevant module page based on lblEdModule.Text
        }
    }

    public class CalendarEvent
    {
        public DateTime Date { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}

