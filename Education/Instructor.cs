using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Instructor {

		public string Name { get; set; }
		public int ExperienceinYears { get; set; }
		public string PrimaryLanguage { get; set; }  //Csharp or Java
		public string Email { get; set; }
		public string Phone { get; set; }

		public Assignment CreateAssignment(string name, string AssignmentId) {
			Assignment asgn = new Assignment();
			asgn.Comments = null;
			asgn.Grade = null;
			asgn.Name = name;
			asgn.AssignmentId = AssignmentId;
			return asgn;
		}


	}
}
