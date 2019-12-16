using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course_manage.Models
{
    public partial class Classes
    {
        
            public string TeacherName
        {
            get { 
                  if(!TeacherId.HasValue)
                  {
                     return"";
                  }
                course_manageEntities db = new course_manageEntities();
                var teacher = db.Teacher.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;

               }
         }
    }
}