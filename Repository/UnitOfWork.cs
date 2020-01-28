using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        private ModelDb context = new ModelDb();


        private GenericRepository<Cedulas> _CedulasRepo;
        public GenericRepository<Cedulas> CedulasRepo
        {
            get
            {
                if (this._CedulasRepo == null)
                    this._CedulasRepo = new GenericRepository<Cedulas>(context);
                return _CedulasRepo;
            }
            set { _CedulasRepo = value; }
        }


        private GenericRepository<Groups> _GroupsRepo;
        public GenericRepository<Groups> GroupsRepo
        {
            get
            {
                if (this._GroupsRepo == null)
                    this._GroupsRepo = new GenericRepository<Groups>(context);
                return _GroupsRepo;
            }
            set { _GroupsRepo = value; }
        }
        private GenericRepository<Templates> _TemplatesRepo;
        public GenericRepository<Templates> TemplatesRepo
        {
            get
            {
                if (this._TemplatesRepo == null)
                    this._TemplatesRepo = new GenericRepository<Templates>(context);
                return _TemplatesRepo;
            }
            set { _TemplatesRepo = value; }
        }
        private GenericRepository<CertificationTypes> _CertificationTypesRepo;
        public GenericRepository<CertificationTypes> CertificationTypesRepo
        {
            get
            {
                if (this._CertificationTypesRepo == null)
                    this._CertificationTypesRepo = new GenericRepository<CertificationTypes>(context);
                return _CertificationTypesRepo;
            }
            set { _CertificationTypesRepo = value; }
        }

        private GenericRepository<Certifications> _CertificationsRepo;
        public GenericRepository<Certifications> CertificationsRepo
        {
            get
            {
                if (this._CertificationsRepo == null)
                    this._CertificationsRepo = new GenericRepository<Certifications>(context);
                return _CertificationsRepo;
            }
            set { _CertificationsRepo = value; }
        }


        private GenericRepository<Dropdowns> _DropdownsRepo;
        public GenericRepository<Dropdowns> DropdownsRepo
        {
            get
            {
                if (this._DropdownsRepo == null)
                    this._DropdownsRepo = new GenericRepository<Dropdowns>(context);
                return _DropdownsRepo;
            }
            set { _DropdownsRepo = value; }
        }


        private GenericRepository<ComplaintTypes> _ComplaintTypesRepo;
        public GenericRepository<ComplaintTypes> ComplaintTypesRepo
        {
            get
            {
                if (this._ComplaintTypesRepo == null)
                    this._ComplaintTypesRepo = new GenericRepository<ComplaintTypes>(context);
                return _ComplaintTypesRepo;
            }
            set { _ComplaintTypesRepo = value; }
        }
        private GenericRepository<PersonalInformations> _PersonalInformationsRepo;
        public GenericRepository<PersonalInformations> PersonalInformationsRepo
        {
            get
            {
                if (this._PersonalInformationsRepo == null)
                    this._PersonalInformationsRepo = new GenericRepository<PersonalInformations>(context);
                return _PersonalInformationsRepo;
            }
            set { _PersonalInformationsRepo = value; }
        }

        private GenericRepository<Meetings> _MeetingsRepo;
        public GenericRepository<Meetings> MeetingsRepo
        {
            get
            {
                if (this._MeetingsRepo == null)
                    this._MeetingsRepo = new GenericRepository<Meetings>(context);
                return _MeetingsRepo;
            }
            set { _MeetingsRepo = value; }
        }
        private GenericRepository<Activities> _ActivitiesRepo;
        public GenericRepository<Activities> ActivitiesRepo
        {
            get
            {
                if (this._ActivitiesRepo == null)
                    this._ActivitiesRepo = new GenericRepository<Activities>(context);
                return _ActivitiesRepo;
            }
            set { _ActivitiesRepo = value; }
        }


        private GenericRepository<Blotters> _BlottersRepo;
        public GenericRepository<Blotters> BlottersRepo
        {
            get
            {
                if (this._BlottersRepo == null)
                    this._BlottersRepo = new GenericRepository<Blotters>(context);
                return _BlottersRepo;
            }
            set { _BlottersRepo = value; }
        }
      
        private GenericRepository<Logs> _LogsRepo;
        public GenericRepository<Logs> LogsRepo
        {
            get
            {
                if (this._LogsRepo == null)
                    this._LogsRepo = new GenericRepository<Logs>(context);
                return _LogsRepo;
            }
            set { _LogsRepo = value; }
        }
      
        private GenericRepository<Provinces> _ProvincesRepo;
        public GenericRepository<Provinces> ProvincesRepo
        {
            get
            {
                if (this._ProvincesRepo == null)
                    this._ProvincesRepo = new GenericRepository<Provinces>(context);
                return _ProvincesRepo;
            }
            set { _ProvincesRepo = value; }
        }

        private GenericRepository<Towns> _TownsRepo;
        public GenericRepository<Towns> TownsRepo
        {
            get
            {
                if (this._TownsRepo == null)
                    this._TownsRepo = new GenericRepository<Towns>(context);
                return _TownsRepo;
            }
            set { _TownsRepo = value; }
        }
       
        private GenericRepository<Actions> _ActionsRepo;
        public GenericRepository<Actions> ActionsRepo
        {
            get
            {
                if (this._ActionsRepo == null)
                    this._ActionsRepo = new GenericRepository<Actions>(context);
                return _ActionsRepo;
            }
            set { _ActionsRepo = value; }
        }

        private GenericRepository<UserRolesInActions> _UserRolesInActionsRepo;
        public GenericRepository<UserRolesInActions> UserRolesInActionsRepo
        {
            get
            {
                if (this._UserRolesInActionsRepo == null)
                    this._UserRolesInActionsRepo = new GenericRepository<UserRolesInActions>(context);
                return _UserRolesInActionsRepo;
            }
            set { _UserRolesInActionsRepo = value; }
        }
       

      

        private GenericRepository<ControllersActions> _ControllersActionsRepo;
        public GenericRepository<ControllersActions> ControllersActionsRepo
        {
            get
            {
                if (this._ControllersActionsRepo == null)
                    this._ControllersActionsRepo = new GenericRepository<ControllersActions>(context);
                return _ControllersActionsRepo;
            }
            set { _ControllersActionsRepo = value; }
        }

     

        private GenericRepository<Items> _ItemsRepo;
        public GenericRepository<Items> ItemsRepo
        {
            get
            {
                if (this._ItemsRepo == null)
                    this._ItemsRepo = new GenericRepository<Items>(context);
                return _ItemsRepo;
            }
            set { _ItemsRepo = value; }
        }

        

        private GenericRepository<Users> usersRepo;
        public GenericRepository<Users> UsersRepo
        {
            get
            {
                if (this.usersRepo == null)
                    this.usersRepo = new GenericRepository<Users>(context);
                return usersRepo;
            }
            set { usersRepo = value; }
        }

        private GenericRepository<UserRoles> userRolesRepo;
        public GenericRepository<UserRoles> UserRolesRepo
        {
            get
            {
                if (this.userRolesRepo == null)
                    this.userRolesRepo = new GenericRepository<UserRoles>(context);
                return userRolesRepo;
            }
            set { userRolesRepo = value; }
        }




        public void Save()
        {
            context.SaveChanges();

        }


        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
    }

}