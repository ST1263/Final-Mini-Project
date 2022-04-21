using ProjectNS.Data;
using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Repo
{
    public class RecallCategoriesRepo:IRecallCategories
    {
        NSDbContext _context;
        public RecallCategoriesRepo(NSDbContext context)
        {
            _context = context;
        }

        public List<RecallCategoriesVM> GetRecallCategories()
        {
            // return _context.RecallCategories.ToList();
            var result = (from a in _context.RecallCategories
                          select new RecallCategoriesVM
                          {
                              RecallCategoriesId = a.RecallCategoriesId,
                              RecallCategoriesName = a.RecallCategoriesName,
                              Description = a.Description,
                              /*RecallInfoId = a.RecallInfoId*/
                          }).ToList();
            return result;
        }

        public RecallCategories GetRecallCategoriesById(int RecallCategoriesId)
        {
            return _context.RecallCategories.FirstOrDefault(a => a.RecallCategoriesId == RecallCategoriesId);
        }

        public RecallCategories AddRecallCategories(RecallCategories recallCategories)
        {
            /* _context.Add(recallCategories);
             _context.SaveChanges();*/
            _context.Add(recallCategories);
            _context.SaveChanges();
            return recallCategories;
        }

        public RecallCategories UpdateRecallCategories(RecallCategories recallCategories)
        {
            /*_context.Update(recallCategories);
            _context.SaveChanges();*/
            _context.Update(recallCategories);
            _context.SaveChanges();
            return recallCategories;
        }

        public void DeleteRecallCategories(int RecallCategoriesId)
        {
            var delrecallcategories = _context.RecallCategories.Where(s => s.RecallCategoriesId == RecallCategoriesId).FirstOrDefault();
            if (delrecallcategories != null)
            {
                _context.Remove(delrecallcategories);
                _context.SaveChanges();
            }
        }
    }
}
