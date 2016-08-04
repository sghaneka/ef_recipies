using EF.DataAccess.Contexts;
using EF.DataAccess.Models.Albums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Test
{
    [TestClass]
    public class SelfReferencingTests
    {
        [TestInitialize]
        public void Init()
        {
            using (var context = new AlbumContext())
            {
                context.PictureCategories.RemoveRange(context.PictureCategories);
                context.SaveChanges();
            }

            using (var context = new AlbumContext())
            {
                var louvre = new PictureCategory { Name = "Louvre" };
                var child = new PictureCategory { Name = "Egyptian Antiquites" };
                louvre.SubCategories.Add(child);
                child = new PictureCategory { Name = "Sculptures" };
                louvre.SubCategories.Add(child);
                child = new PictureCategory { Name = "Paintings" };
                louvre.SubCategories.Add(child);
                var paris = new PictureCategory { Name = "Paris" };
                paris.SubCategories.Add(louvre);
                var vacation = new PictureCategory { Name = "Summer Vacation" };
                vacation.SubCategories.Add(paris);
                context.PictureCategories.Add(vacation);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelf_Referencing_Content()
        {
            // Assert there are 6 categories
            using (var context = new AlbumContext())
            {
                int count = context.PictureCategories.Count();
                Assert.AreEqual(count, 6);
            }

            using (var context = new AlbumContext())
            {
                PictureCategory cat = context.PictureCategories.Where(x => x.Name == "Egyptian Antiquites").FirstOrDefault();
                // sub's are not loaded by default
                PictureCategory[] subs = cat.SubCategories.ToArray();
                Assert.AreEqual(subs.Length, 0);
                // force the sub's to load
                context.PictureCategories
                    .Where(x => x.Name == "Egyptian Antiquites")
                    .Include(x => x.ParentCategory)
                    .FirstOrDefault();
                // they should be now
                subs = cat.SubCategories.ToArray();
                Assert.AreEqual(subs.Length, 2);
            }

           
        }
    }
}
