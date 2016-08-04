using EF.DataAccess.Contexts;
using EF.DataAccess.Models.Poems;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console
{
    public static class Poets
    {
        public static void Load()
        {
            using (var context = new PoetryModelContext())
            {
                // One poet can write many poems
                // One meter can be part of many poems

                // If you delete the meter, then it will delete the poems (if you set the cascade delete on)
                // Similarly, if you delete the poet, it will the delete the poems


                var poet = new Poet { FirstName = "John", LastName = "Milton" };
                var poem = new Poem { Title = "Paradise Lost" };
                var meter = new Meter { MeterName = "Iambic Pentameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);
                poem = new Poem { Title = "Paradise Regained" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                poet = new Poet { FirstName = "Lewis", LastName = "Carroll" };
                poem = new Poem { Title = "The Hunting of the Shark" };
                meter = new Meter { MeterName = "Anapestic Tetrameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                poet = new Poet { FirstName = "Lord", LastName = "Byron" };
                poem = new Poem { Title = "Don Juan" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.Add(poem);

                context.SaveChanges();
            }
        }

        public static void DeleteOp()
        {
            using (var context = new PoetryModelContext())
            {
                var milton = context.Poets.
                    Include(x => x.Poems).
                    Where(x => x.LastName == "Milton").FirstOrDefault();

                context.Poets.Remove(milton);
                context.SaveChanges();
            }
        }

    }
}
