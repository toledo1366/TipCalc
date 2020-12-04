using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using System.Threading.Tasks;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {

        //Dependency injection is here:
        readonly ICalculationService _calculationService;

        public TipViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }


        //Initialize method here is part of ViewModel lifecycle
        public override async Task Initialize()
        {
            await base.Initialize();

            _subTotal = 100;
            _generosity = 10;

            Recalculate();
        }

        /*The view data held within the TipViewModel is exposed through properties, where:
         *  - Each of these properties is backed by a private member variable
         *  - Each of these properties has a getter and setter
         *  - All of the set accessors call RaiseProphertyChanged to tell the base MvxViewModel that the data has changed
         *  - SubTotal and Generosity set accessors also call Recalculate()
         */

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);

                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);

                Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        //The private Recalculate method uses the _calculationService to update Tip from the current values of SubTotal and Generosity.
        private void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }
    }
}
