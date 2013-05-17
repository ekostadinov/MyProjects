using SideshowBob;
using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;
using SideshowBobUI.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SideshowBobUI.ViewModel
{
    public class VehicleViewModel : Vehicle
    {
        #region Fields

        private Vehicle selectedVehicle;
       
        #endregion

        #region Constructors

        public VehicleViewModel()
        {
            RemoveCommand = new DelegateCommand(OnExecuteRemoveCommand, CanExecuteRemoveCommand);
            //Hardcode
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Black", 4, Model.AudiA8, DateTime.Now, 12000m, true, false, 5));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Yellow", 4, Model.BentleyAzure, DateTime.Now, 12300m, true, false, 6));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("White", 4, Model.BMW5Series, DateTime.Now, 71203m, true, false, 5));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Green", 4, Model.CitroenJumper, DateTime.Now, 60500m, true, false, 4));
        }
        #endregion

        #region Properties

        public IEnumerable<Category> Categories
        {
            get
            {
                return AuthorisedDealer.Instance.CategoryValues;
            }
        }

        public IEnumerable<Model> BrandModels
        {
            get
            {
                return AuthorisedDealer.Instance.BrandModelValues;
            }
        }

        public ObservableCollection<Vehicle> ListOfVehicles
        {
            get
            {
                return AuthorisedDealer.Instance.Vehicles;
            }
            set
            {
                if (AuthorisedDealer.Instance.Vehicles == value) return;

                AuthorisedDealer.Instance.Vehicles = value;
            }
        }


        //private string dateAndYear;
        //public string Year
        //{
        //    get
        //    {
        //        return dateAndYear;
        //    }
        //    set
        //    {
        //        this.dateAndYear = this.Year.Month + "/" + this.Year.Year;
        //    }
        //}



        public Vehicle SelectedVehicle
        {
            get
            {
                return selectedVehicle;
            }
            set
            {
                if (this.selectedVehicle == value)
                {
                    return;
                }

                this.selectedVehicle = value;

                if (value != null)
                {
                    this.Color = value.Color;
                    this.Wheels = value.Wheels;
                    this.Model = value.Model;
                    this.Year = value.Year;
                    this.Price = decimal.Parse(value.Price.ToString());
                    this.Speed = value.Speed;
                    RemoveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        #region Remove Command

        public DelegateCommand RemoveCommand
        {
            get;
            set;
        }

        public void OnExecuteRemoveCommand(object e)
        {
            ListOfVehicles.Remove(SelectedVehicle);
        }

        private bool CanExecuteRemoveCommand(object e)
        {
            if (SelectedVehicle != null) return true;

            return false;

        }

        #endregion

        #endregion

        #region Methods

        public override void AbleToTransport()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
