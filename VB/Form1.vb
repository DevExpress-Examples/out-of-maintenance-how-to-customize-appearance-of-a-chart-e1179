Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ChartAppearance
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' Create an empty chart.
            Dim barChart As New ChartControl()

            ' Create a series and add points to it.
            Dim series1 As New Series("Bar Series", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 12 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 14 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 17 }))

            ' Add the series to the chart.
            barChart.Series.Add(series1)

            ' Customize the chart's appearance.
            barChart.AppearanceName = "Dark"
            barChart.PaletteName = "Opulent"
            barChart.PaletteBaseColorNumber = 5

            ' Add the chart to the form.
            barChart.Dock = DockStyle.Fill
            Me.Controls.Add(barChart)
        End Sub

    End Class
End Namespace