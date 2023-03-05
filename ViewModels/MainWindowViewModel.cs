using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PracticeAvalonia.ViewModels.Page;

namespace PracticeAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object content;
        private ObservableCollection<ViewModelBase> vmbaseCollection;

        public MainWindowViewModel()
        {
            vmbaseCollection = new ObservableCollection<ViewModelBase>();
            vmbaseCollection.Add(new ForChildrenViewModel());
            vmbaseCollection.Add(new CultureViewModel());
            vmbaseCollection.Add(new EducationViewModel());
            vmbaseCollection.Add(new ExcursionsViewModel());
            vmbaseCollection.Add(new LifeStyleViewModel());
            vmbaseCollection.Add(new OnlineViewModel());
            vmbaseCollection.Add(new PartiesViewModel());
            vmbaseCollection.Add(new ShowViewModel());
            vmbaseCollection.Add(new SportViewModel());

            Content = vmbaseCollection[0];
        }

        public object Content
        {
            get => content;
            set
            {
                this.RaiseAndSetIfChanged(ref content, value);
            }
        }

        public ObservableCollection<ViewModelBase> VmbaseCollection
        { 
            get => vmbaseCollection;
            set
            {
                this.RaiseAndSetIfChanged(ref vmbaseCollection, value);
            }
        }

    }
}