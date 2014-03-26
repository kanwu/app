using System.Collections.Generic;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;

namespace app.specs.web
{

    [Subject(typeof (ViewADepartment))]
    public class ViewADepartmentSpecs
    {
        public abstract class concern : Observes<IImplementAUserStory,
            ViewADepartment>
        {
        }


        public class when_run : concern
        {
            private Establish c = () =>
            {
                request = fake.an<IProvideDetailsAboutARequest>();
                departments = depends.on<IFindDepartments>();
                display_engine = depends.on<IDisplayInformation>();

                the_department = new DepartmentDetails();
                departments.setup(x => x.get_department_by_id(departmentId)).Return(the_department);

            };

            private Because b = () => sut.process(request);

            private It display_the_department = () =>
                display_engine.received(x => x.display(the_department));

            private const int departmentId = 123;

            private static IFindDepartments departments;
            private static IProvideDetailsAboutARequest request;
            private static IDisplayInformation display_engine;
            private static DepartmentDetails the_department;
        }

    }
}
