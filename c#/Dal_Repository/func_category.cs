using Dal_Repository.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
  public class func_category:IDal_Repository.IDal_category<DTO_Commom.new_model.Category>
  {
    GardenContext gc = new GardenContext();
    public List<DTO_Commom.new_model.Category> SelectAllCategory()
    {
      
      var cc = gc.categories.ToList();
      return converts.To_DTO.catDl(cc);
    }
    
    
    
    //public async Task<List<Dto_Common_Enteties.CourseDto>> SelectAllAsync()
    //{
    //  SchoolContext db = new SchoolContext();
      
    //  var q1 = await db.Courses.Include("Depart").ToListAsync();
      
    //  return Converters.CoursesConverters.ToListCourseDto(q1);

    //}
  }
}
