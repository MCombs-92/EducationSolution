using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Program {
		static void Main(string[] args) {

			Instructor Dan = new Instructor();
			Dan.Name = "Dan";
			Dan.ExperienceinYears = 17;
			Dan.PrimaryLanguage = "CSharp";
			Dan.Email = "Dan@Military.gov";
			Dan.Phone = "123-456-7890";


			Class dotnetbc4 = new Class();
			dotnetbc4.Capacity = 16;
			dotnetbc4.Code = "DN4";
			dotnetbc4.Language = "CSharp";
			dotnetbc4.Name = "Dont Net Boot Camp 4";
			dotnetbc4.Instructor = Dan;


			Student Foster = new Student();
			Foster.Absences = 0;
			Foster.ContactInfo = "Call Foster...";
			Foster.FirstJob = null;
			Foster.Name = "Foster";
			Foster.Class = dotnetbc4;


			Student JJ = new Student();
			JJ.Absences = 0;
			JJ.ContactInfo = "Call Jon...";
			JJ.FirstJob = null;
			JJ.Name = "Jonathan";
			JJ.Class = dotnetbc4;

			dotnetbc4.Students.Add(Foster);
			dotnetbc4.Students.Add(JJ);

			Assignment as1 = Dan.CreateAssignment("First Fundamentals assignment", "Fundamentals 12");
			dotnetbc4.DistributeAssignment(as1);

			//Assignment as1 = new Assignment();
			//as1.AssignmentId = "Fundamentals12";
			//as1.Comments = null;
			//as1.Grade = null;
			//as1.Name = "First Fundamentals Assignment";

			//Foster.Assignments.Add(as1);
			//JJ.Assignments.Add(as1);


		}
	}
}
