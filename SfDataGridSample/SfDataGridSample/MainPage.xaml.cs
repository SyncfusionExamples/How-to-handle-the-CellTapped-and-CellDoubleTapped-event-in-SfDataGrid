using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sfGrid_CellTapped(object sender, DataGridCellTappedEventArgs e)
        {
            DisplayAlert("Cell Tapped", $"Cell tap performed on row {e.RowColumnIndex.RowIndex} and column {e.RowColumnIndex.ColumnIndex}.", "OK");
        }

        private void sfGrid_CellDoubleTapped(object sender, DataGridCellDoubleTappedEventArgs e)
        {
            DisplayAlert("Cell Double Tapped", $"Cell Double tap performed on row {e.RowColumnIndex.RowIndex} and column {e.RowColumnIndex.ColumnIndex}.", "OK");
        }
    }
}
