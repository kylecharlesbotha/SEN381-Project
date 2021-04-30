using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using PremierServiceSolutions.Business_Logic_Layer;
using PremierServiceSolutions.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Pages
{
    public partial class frmDash : Form
    {
        TicketDH ticketDH = new TicketDH();
        List<Ticket> tickets = new List<Ticket>();
        List<int> technicianIDs = new List<int>();
        TechnicianDH technicianDH = new TechnicianDH(); 
        public frmDash()
        {
            InitializeComponent();
            tickets = ticketDH.GetTicketsGroupedByDate();
            SetStatusPieChart();
            SetIssueTypePieChart();
            SetPriorityPieChart();
            SetTechnicianStatsPieChart();
            LineSeries DailyTicketLineSeries = new LineSeries
            {
                Values = new ChartValues<ObservablePoint>
                {
                    new ObservablePoint(0,0)
                }
            };
            
            cartesianChartDailyTickets.Series = new SeriesCollection
            {
                DailyTicketLineSeries
            };
            cartesianChartDailyTickets.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = GetDates(DailyTicketLineSeries).ToArray()
            }) ;
            cartesianChartDailyTickets.AxisY.Add(new Axis
            {
                Title = "Number of tickets",
                LabelFormatter = value => value.ToString()
            });
            DailyTicketLineSeries.Values = ConvertToObservablePoints();              
        }

        private void frmDash_Load(object sender, EventArgs e)
        {

        }
        public void RefreshDailyTicketLineSeries()
        {
            List<ObservablePoint> DataPoints = new List<ObservablePoint>();
            LineSeries DailyTicketLineSeries = new LineSeries
            {

                Values = new ChartValues<ObservablePoint>
                {
                    null
                }
            };
            foreach (ObservablePoint point in DataPoints)
            {
                DailyTicketLineSeries.Values.Add(point);
            }
        }
        public void AddToDailyTicketLineSeries(ObservablePoint point, LineSeries DailyTicketLineSeries)
        {
            DailyTicketLineSeries.Values.Add(point);
        }
        private void pnlHelpDesk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChartDailyTickets_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        public ChartValues<ObservablePoint> ConvertToObservablePoints()
        {
            ChartValues<ObservablePoint> points = new ChartValues<ObservablePoint>();
            int count = 0;
            foreach (Ticket ticket in tickets)
            {
                points.Add(new ObservablePoint(count, ticket.CountOnDate));
                count++;
            }
            return points;
        }
        public List<String> GetDates(LineSeries DailyTicketLineSeries)
        {
            List<String> dates = new List<String>();
            tickets = ticketDH.GetTicketsGroupedByDate();
            int counter = 1;
            foreach (Ticket ticket in tickets)
            {

                DailyTicketLineSeries.Values.Add(new ObservablePoint(counter, ticket.CountOnDate));
                dates.Add(ticket.TicketDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                counter++;
            }
            return dates;
        }
        public void SetStatusPieChart()
        {
            pieChartStatus.InnerRadius = 40;
            pieChartStatus.LegendLocation = LegendLocation.Bottom;
            pieChartStatus.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "In Progress",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByStatus("In Progress")},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Assigned",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByStatus("Assigned")},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Unassigned",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByStatus("Assigned")},
                    DataLabels = true
                }
            };
        }
        public void SetIssueTypePieChart()
        {
            //pieChartIssueType.InnerRadius = 40;
            pieChartIssueType.LegendLocation = LegendLocation.Bottom;
            pieChartIssueType.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Remote",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("Remote") },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "On site",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("Onsite") },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "In House",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("InHouse") },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Workshop",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("Workshop") },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Managed Services",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("Managed Services") },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Other",
                    Values = new ChartValues<double> {ticketDH.GetTicketCountByIssueType("Other") },
                    DataLabels = true
                }
            };
        }
        public void SetPriorityPieChart()
        {
            pieChartPriority.InnerRadius = 40;
            pieChartPriority.LegendLocation = LegendLocation.Bottom;
            pieChartPriority.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "High",
                    Values = new ChartValues<double> {6 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Medium",
                    Values = new ChartValues<double> {7 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Low",
                    Values = new ChartValues<double> {8 },
                    DataLabels = true
                }
            };
        }
        public void SetTechnicianStatsPieChart()
        {
            pieChartTechnicianStats.InnerRadius = 40;
            pieChartTechnicianStats.LegendLocation = LegendLocation.Right;
            technicianIDs = ticketDH.GetTechnicianIDs();
            foreach (int technicianID in technicianIDs)
            {
                Technician currentTechnician = technicianDH.GetByID(new Technician(technicianID)); 
                pieChartTechnicianStats.Series.Add(NewSeries(currentTechnician.TechName, ticketDH.GetTechniciansTicketCount(technicianID))); 
            }
        }
        public PieSeries NewSeries(string title, int value)
        {
            return new PieSeries
            {
                Title = title,
                Values = new ChartValues<double> { value },
                DataLabels = true
            };
        }
        private void lblYourOpentickets_Click(object sender, EventArgs e)
        {

        }
    }
}
