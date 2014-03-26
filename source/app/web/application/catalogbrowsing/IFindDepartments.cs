using System.Collections.Generic;

namespace app.web.application.catalogbrowsing
{
  public interface IFindDepartments
  {
    IEnumerable<DepartmentLineItem> get_the_main_departments();
    DepartmentDetails get_department_by_id(int id);
  }
}