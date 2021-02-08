using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymMvc.Models;

namespace GymMvc.Data
{
    public class SeedingService
    {
        private GymMvcContext _context;
        public SeedingService(GymMvcContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if (_context.Instructor.Any() || 
                _context.Membership.Any() || 
                _context.Modality.Any() ||
                _context.Payment.Any())
            {
                return;
            }

            Instructor i1 = new Instructor(1, "Joao Black", "82704707081", "jblack@jmail.com", "85884848482");
            Instructor i2 = new Instructor(2, "Mara Pink",  "72143722079", "marapink@jmail.com", "85881231232");
            Instructor i3 = new Instructor(3, "Davi Green", "21101021012", "davigreen@jmail.com", "85987878482");
            Instructor i4 = new Instructor(4, "Pedro Blue", "12043706055", "pblue@jmail.com", "85878748482");

            Membership m1 = new Membership(1, "99568698051", "John Lennon", "jlennon@jmail.com", "81888888888", new DateTime(1940, 10, 21));
            Membership m2 = new Membership(2, "96878586054", "Paul McCartney", "pmccartney@jmail.com", "81777777777", new DateTime(1950, 12, 11));
            Membership m3 = new Membership(3, "89893586046", "Ringo Starr", "rstarr@jmail.com", "81998851111", new DateTime(1999, 01, 18));
            Membership m4 = new Membership(4, "72763426034", "George Harrison", "gharrison@jmail.com", "81666664444", new DateTime(1940, 02, 02));
            Membership m5 = new Membership(5, "11164878026", "Janis Joplin", "jjoplin@jmail.com", "81664444444", new DateTime(1988, 06, 02));
            Membership m6 = new Membership(6, "75112350008", "Dolores O'Riordan", "doloreszombie@jmail.com", "81663264444", new DateTime(1971, 03, 12));
            Membership m7 = new Membership(7, "29934187000", "Amy Winehouse", "awcantora@jmail.com", "81665555544", new DateTime(2003, 07, 26));

            Modality mo1 = new Modality(1, "Muay Thai", i1);
            Modality mo2 = new Modality(2, "Capoeira", i2);
            Modality mo3 = new Modality(3, "Jiujitsu", i4);
            Modality mo4 = new Modality(4, "Musculação", i3);
            Modality mo5 = new Modality(5, "Mma", i1);
            Modality mo6 = new Modality(6, "Judo", i4);
            Modality mo7 = new Modality(7, "Cross-Fit", i3);

            Payment p1 = new Payment(1, m1, new DateTime(2021, 02, 08), new DateTime(2021, 03, 08),mo1);
            Payment p2 = new Payment(2, m2, new DateTime(2021, 02, 14), new DateTime(2021, 03, 14), mo2);
            Payment p3 = new Payment(3, m3, new DateTime(2021, 02, 11), new DateTime(2021, 03, 11), mo3);
            Payment p4 = new Payment(4, m4, new DateTime(2021, 02, 13), new DateTime(2021, 03, 13), mo4);
            Payment p5 = new Payment(5, m5, new DateTime(2021, 02, 17), new DateTime(2021, 03, 17), mo5);
            Payment p6 = new Payment(6, m6, new DateTime(2021, 02, 10), new DateTime(2021, 03, 10), mo6);
            Payment p7 = new Payment(7, m7, new DateTime(2021, 02, 01), new DateTime(2021, 03, 01), mo7);
            Payment p8 = new Payment(8, m1, new DateTime(2021, 01, 08), new DateTime(2021, 02, 08), mo7);
            Payment p9 = new Payment(9, m2, new DateTime(2021, 01, 13), new DateTime(2021, 02, 13), mo6);
            Payment p10 = new Payment(10, m3, new DateTime(2021, 01, 08), new DateTime(2021, 02, 08), mo5);
            Payment p11 = new Payment(11, m4, new DateTime(2021, 01, 13), new DateTime(2021, 02, 13), mo4);
            Payment p12 = new Payment(12, m5, new DateTime(2021, 01, 18), new DateTime(2021, 02, 18), mo3);
            Payment p13 = new Payment(13, m6, new DateTime(2021, 01, 13), new DateTime(2021, 02, 13), mo2);
            Payment p14 = new Payment(14, m7, new DateTime(2021, 01, 15), new DateTime(2021, 02, 15), mo1);
            Payment p15 = new Payment(15, m1, new DateTime(2021, 01, 04), new DateTime(2021, 02, 04), mo3);
            Payment p16 = new Payment(16, m2, new DateTime(2021, 01, 02), new DateTime(2021, 02, 02), mo4);
            Payment p17 = new Payment(17, m3, new DateTime(2021, 01, 08), new DateTime(2021, 02, 08), mo5);

            _context.Instructor.AddRange(i1, i2, i3, i4);
            _context.Membership.AddRange(m1, m2, m3, m4, m5, m6, m7);
            _context.Modality.AddRange(mo1, mo2, mo3, mo4, mo5, mo6, mo7);
            _context.Payment.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17);

            _context.SaveChanges();

        }

    }
}
