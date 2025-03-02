using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Service;
using CommonLayer;

namespace BusinessLayer.Interface
{
    public interface IEmployeeBL
    {
        void AddEmployee(Employee employee);
    }
}
