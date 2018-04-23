using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ChartAppearance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl barChart = new ChartControl();

            // Create a series and add points to it.
            Series series1 = new Series("Bar Series", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 17 }));

            // Add the series to the chart.
            barChart.Series.Add(series1);

            // Customize the chart's appearance.
            barChart.AppearanceName = "Dark";
            barChart.PaletteName = "Opulent";
            barChart.PaletteBaseColorNumber = 5;

            // Add the chart to the form.
            barChart.Dock = DockStyle.Fill;
            this.Controls.Add(barChart);
        }

    }
}