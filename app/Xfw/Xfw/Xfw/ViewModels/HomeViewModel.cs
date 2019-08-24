using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xfw.Models;
using Xfw.Services;
using Xamarin.Forms;

namespace Xfw.ViewModels
{
    public sealed class HomeViewModel : BaseViewModel
    {
        private readonly IMovieService movieService;

        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public HomeViewModel()
        {
            movieService = new MovieService();
        }

        public ObservableCollection<Movie> Movies
        {
            get => movies;
            set { movies = value; OnPropertyChanged(); }
        }

        public override async Task Initialize()
        {
            await ExecuteBusyAction(async () => {

                (var error, var upcomingMovies) = await movieService.GetUpcoming();

                if (error != null)
                {
                    await Application
                    .Current
                    .MainPage.DisplayAlert("Error", error, "Ok");

                    return;
                }

                Movies = new ObservableCollection<Movie>(upcomingMovies);

            });
        }
    }
}
