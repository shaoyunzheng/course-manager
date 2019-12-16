using course_manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course_manage.Migrations.seeds
{
    public class SideBarCreator
    {
        private readonly course_manage.Models.course_manageEntities _context;

        public SideBarCreator(course_manage.Models.course_manageEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {
                    Name = "班级管理",
                    Controller = "Class",
                    Action = "Index"
                },
                new SideBars
                {
                    Name = "教师管理",
                    Controller = "Teacher",
                    Action = "Index"
                },
                new SideBars
                {
                    Name = "学生管理",
                    Controller = "Student",
                    Action = "Index"
                },
                new SideBars
                {
                    Name = "课程科目管理",
                    Controller = "Course",
                    Action = "Index"
                },
                new SideBars
                {
                Name = "课程安排",
                Controller = "CourseManagenent",
                Action = "Index"
                },
                new SideBars
                {
                Name = "顶部导航栏管理",
                Controller = "ActionLink",
                Action = "Index"
                },
                new SideBars
                {
                Name = "侧边栏管理",
                Controller = "SideBar",
                Action = "Index"
                }
            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}