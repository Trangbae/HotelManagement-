using hotelManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagement.Controller
{
    internal interface IController
    {
        List<IModel> Items { get; }
        public IModel Read(Object id);
        public bool Load();
        public bool Load(Object id);
        public bool Create(IModel model);
        public bool Update(IModel model);
        public bool Delete(IModel id);
        public bool IsExist(Object model);
    }
}
