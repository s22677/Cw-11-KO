using System.Collections.Generic;
using System.Linq;

namespace blazor_25c.Data
{
    public class StudentService : IStudentService
    {
        private List<Student> students;
        public StudentService()
        {
            students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Jan",
                    LastName = "Papaj",
                    Birthdate = new System.DateTime(2010, 1, 1),
                    Studies = "Ble",
                    Avatar = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBYWFRgVFRYYGRgYGhgaGhoaGhgaGhkaGhoaGhocGBgcIS4lHB4rHxoYJjgmKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHxISHzQhJCE0NDQ0NDExNDQ0NDQ0MTQ0NDQ0NDQ0MTQ0NDQ0NDE0NDQ0NDQ0NDQ0PjQ1Oj8xNDQ0Mf/AABEIAOEA4QMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAABAIDAQUGBwj/xAA+EAACAQICBwUHAwIDCQAAAAAAAQIDEQQhBRIxQVFhcQaBkaHwIjJSscHR4RNC8SOSFGJyBxUWMzSCorLC/8QAGgEAAwEBAQEAAAAAAAAAAAAAAAECAwQFBv/EACIRAAICAgIDAQEBAQAAAAAAAAABAhEDIQQSMUFRIhNhMv/aAAwDAQACEQMRAD8A9mAAAAAAADVaf0msPRlN+8/ZguMmnb5N9x5hBOTcnm2223vbzbOt/wBoMruhG/xtq/8ApSdv7s+pzNGB4/Om5T6+kd/GjUb+lsIg2XRiuO4Xm8+XrwOF6o6BimX3FqMi+TLCjDZfSF7l0E2NMTG4MZppcBWEENUUuC7/AMm0QoahJLejEu7xJq/JEZRNdCKpLiipxTGWR1I8CaHQv+m9zCVCXEudLgyP6b4oTQEY4biySwy4mYwfEkocxJDoXxGGssn3Gsc7OzN1UptraanGUM7mWVPygSH9FYzUmpbtj5p+rnao83oTO60PitelF717L6r8WfeehwclxcTj5UKakbAAA9A5AAAAAAAAAMMyYYAeedsqjlibfDCKXfd//RqKSGNOVXPEVW7X15R7ovVXkkUQR87yJdsjf+nqYo1BFs55C81mSnIxBGN+jWidMZiyNOBJoqKEzKLVKxSmXUYlIQxTi97H8Mk3mJJpe8xmhUjufmdENbYmPuEeBCTRXdPf53IuG9M0b+AixdTKgxfXLozIUrKJO/AgSc+ZVKoNtCTJ3JK5R+qH63MSYF0pC1aNzM66K02wdPQCc6VjedlK71pw3NKS6p2fzXgIyp5C2GxDo1Yz3J+1/peUvLPuHiaxzT9GeWPaDR6CBXCSaTW8meyjzDIAAwMAAhpTHqlG+2TyiuL58lkKUlFWxpNukPkJysm3uVzlY6YrNp6y6aqs/qPV9IqdCopWjLUllfJ9Gc65MJXRq8Mo7ZwU5uUpSe2Tb8c38yV8iuDJs8OcrbZ6UFoqkxqjEhGA1QiZJOyy2MDEo5jMIEKsDaK0SxWxmpiUvkFXZ3msrQcntNKIbGp4u23xWYhPHyvl66lklGCvKSS5/kUqaSofGn5mi3qiBqjpxx2qxt8LpiMtrOVliKcvdkm+pFNrNFSxvyhdjuf8SmTjXOPwukJJJN5GxhjL7zBuns0TN/8ArBKYnRbtntIzqWtfYOwsvnVI/qmtxWLS3msr6Ystv5GlsG9HSqaWcmi6ONjuZxb0tKW7vzHKGksrSSfPYzWMb8mbl8OqhpCPFPoxbEyUthoIYhN32c19R+hJ8RSRUZM7DsrjPZcG+cfPWX18TpjgdCV9WcXwmvPL5M709LiybhT9HDnjUteyQGDJ0mJE5jtBNTqxgv2Rz5OVnbwS8TqDi51darUlxnJLpF2Xkjk5bfSl7OjjRud/DMYWtcrxEbxa2raZqXlvskUyT1Wr7meWlR6L2c89rJIzU2kYnN7KRfTiO0IitEeooa8gMRiQnJrc/AvgiTiapCZrKzvwNTjFUu1CN29jd9Vc+Z0/6VyNShvXrxNImbiee47QGJb1pJzvnln/AOPDoaXEYapF2dNx3bJbvuex03G2azFcSlxXfZ/M6llUUYvGec6P0Rem5Tyk9i3lUsNODaV8t3HodviakVsaz6Grm77rkf2QRxs0WEjNtexJLjnY6LBw1fasM6Mwkr6zVlwNksKkrWMptS2jSMSFJ3RRjnaJt6MFa1kV4jCJxaUUKMdFNHnOkcdeTUe9mpliJN5K+zNm70jomUJSdt5DA6JcneWSOmMYRRg+zNBVxc0r6z6JKwzg6052s3dnWf8ADVOVs34/QdwfZanF5O3U0/rBkqEjnKFSpFpNJ7OqOo0fK68LrenzHIaHpQ2K9t5dHDRV3ZX7jlySUjaMWimhK0n0PSKXux6L5Hmc5WmuaaPTKPux6L5HVwXpo5uUtotAwZPQOUVxtbUpyl8MZPvSy8zhqVVpJLOT9XOi7WVWqcYr90s+aSvbpe3gc/RlqpzazPO5c7aj8O3jRpOROpNpKC23zLZWWzYkI4aTlJyYziHqxbONHTZo66zIwiXYmJCCOeUfLKjIYoRHqQnRQ1GViIl2NxeRbARVXkX0pM2TEOwijFSCtYIMtUTaLtCZr6kJpZK65ilVSeyHmjdSiVygTJWKjQLAye5LzY1htGxW27fM2bQEpUOiCppFNSRfMVqMJMEM4VXGXD2WxfBZjkF7LNca/JEmIvBQn7yQridD6ucM470/ubOgMWNFtCaObhCMXnFrzGI1IJZRk3zubeVFPcZjTSI/m/QI1cYN5yTS9bSrE1MuJt60E1s+hpcXGzJlHqh2ITV5RfBnqUTyyeR6dhZ60Iu97xTvxuk7nZwXpo5OV5RcAAegchx/aSvrV1HdCKX/AHSzflqiVWPsFelautXm/wDO1/a9X5JDLjkuh42aTlNnpYo1BGkp6QjCdpbHv6jE6zqSy9xbOfMzidGRk3L13kqKUY5GKcnpo1lSQpjZZlMGFa85N7k7FlOmOUJURGSsvpMvTF6aGDFRL7GdaxKnVKJshGRQJm6oTGoyNThqo5CoaJ0ivI02VyZU6pCVUXdDonOZVKsLYjEpGvninJ2W0yll3SHRuozTKaiFqNOSzu2WufEbdq2Ie0fLaOUlkxLAofpReZ1Y/wDlGchFT1WMRxC4iNeLcms+41WIqSpzzbafqxPdxbfoZ1EZonkaXDYy9sxyOIKjlTF1GK0jUYtDdWsa+rK5E5WHgVmjvdA1VLD02ne0VF9Y+y15HCzidZ2Qn/RlHfGb80nf5nVw3TZy8haTOgAyB6RxnnumX/UnLZ/UkvBsthN6txztLg3rSaVlJKSe5yV014WNPQxKtqydmuJ42ZdZs9LE04Itni7RkrXurc88hWadki6lDXlrNezHLqyirVV3zv6+YYY9nsWSVItcIxilbPa/p9yrj08M/wAEFWv5/IlD6L5m+WqMIXZKKLUyqJNs4Ox10QmiBNsi0SxonTmMKqKRJ6xLbLQw6pTUrlM5mvxWKtfMlpjJ4qu27LaxujhXBa3S5HQ2Fb9uW/Ynw4nQRpRtZ7HkzWOHQdhbDVFbMxWsK4ihOF3Bay5bfB7RWjjru0rp8JZPwYtpUxG/wE0kP0qyV2c7SxViU8auJvHJUSZRsdc/bbNF2hxCWq+Y08S3ktvkhLS+C14NrOSzQX2JuhXCYs3OHxFzjcPUadnfL5nQ4CpcylFxZaZuHMrcicY5FcluK9EvyYmsja9lK7jVcG8pJ2X+ZWd/C5rGsh/s7/z48Xr9y1WdPHdTRhnVxZ2xkAPWOAXxOGjNWkk1t6PiuBz2P0I07xjrrds1lyz3dDqTBlPFGfkuOSUfByMdHVJ++v0qcV7V7Xsld6qz8Ti51Hs5X8L3PTe0jthqtvhXnJI8tlTbfriR/KMFovu5PYzhJ38P57x+Wxcsn68DWYSbXd6Y7r/g5cy/JtDyXwZmbIwMyR5p1hElqhHgTQxIg4EZIvSIyjcKHZq8TLIzo/R+u1OfcvqxyeFu0NwyKVJBZfDLJF8JCEay4jFOsUpBZdNi2JpxmrSV/muae4tc7lbTBjs0uJoTh7vtrraQhSrSk7SyOilEVxGFi89hCS8ktslhrDSkhCkrF361stre4rtWiaNVpfDR1tZJJ/MZ0VSF9K4WacZSkrSdtVbjbaKo5I0f6Ssa0PKCS5kHAd/TS/gWqD6gVNDmg1bEQfOS8YtC9jY9nqGtV1nf2FfveS8nLwNcK/aoyy11Z1pkwZPVPPAAAYGp7Tf9NU6R/wDaJ53Ckpaz4/VWf08D03StJzo1IrNuErLi7ZLxPKNG1nGTg9jdl12/fIiSGvJmzT9ZemNUmUYiWrLNZPb0LUtV22rc+KOTLHR0QY3TRYkQpMvUTya/R2lbRKJmQQZVAiaRlIIomkNDZhQJVKTaJwgM0oGijYjRvR8b+1reLXyJ/wCDml7E7/6l9Ub2phLlP+GsDg0F2aWSrr4ZdG0UyxFffB9zTN86bBZEOCKRoKeLnf2oSXWLZKU6k37EL82rLzOgST3Eox5AoDNLDAVH707cl9xqnhIw2bd7e02X6bJKgUsZJqcdhXJLk7mx0dhbLYMwpjVKFjeMPpD0UTp8hOtA2VVs11faU0kIWaN/2ZXsz6r5GhudToKFqSb/AHNy8f4NuPG5X8MM7/NGzAwB3nGZAAADDPHtP4Z0cTOEsru8X1zTXc+49hOL7d6ElUSrU46zjlOKV3ZbJLjbh0E/AHHUsWppRnt3S+5YptLVlu9XQjhpLY+OTNg6WS5bOOe7pwOeatG8ZbHMNLZzHoo1GHm1Kz2ZZ+f1RtISPJmqkdsXaMzRmETLQRFRRNIsiQgWQQ0hl0EOUYC0BujI2iJjMYlc4E4zMSmaPwQrsXlAplTRdOZBzMmjRFagi2MSKLIAkMsiiVjEQkzREszFlqkKORLXKTJaLKrNdXkX1agjWmDJbDDw1pRXxNLxaX1O4pU1FKKVkkkuiON0ZD+rBf5l4p3+h2x1caNJs5M7toyAAdRgAAAABgyAAeSaW0eqOJqQjlFSvHhqySkklwV7c7DFOCtbdu5dPsdd2t0LGrTlViv6sItprbNRzcWt/LnY8+paRbWW22z1tMpRoqLGcQrPd168h3DTujUrGp+t/BjmHnst3/g87PDdnZjlo2VzKK4TJJnIzoRbEYihWmMQkOLGXwL4sVUiyMzRSAbVXmRdQXczGsV2FRa2ZRRrh+qF2FjGsZjMWUrkkylFichvWIyqFaeXrYVyKcWLsSlMi6hTORVKZNibLJ1PqVuZXtGsFhXOcYre1fpvNYJydGc5UrNr2ewjcnUayStHm3tfh8+R0ZVQpKMVGOxKyLT0IR6qjilLs7MgAFkgAAAAAAAGGjz7tj2TzliKCttlOK3cZQ820ehGGhNWB8/1ZtcmtvB7h7RuMvbisnz+zO07U9i3PWnQtd5uNvV15rmcDGhOlPVnG3mnzT2HPmho2xy2dPRqjMZmqw8k0nFrPxGqdbxPNniaOuMh+Ey2MxKNQnGZikzWx1TJKYoqhKNUrq2LshlSJa4jPFpZLNkY1rq79fc1jBkPIbCVT19iVKm3t9ISpVd+8djVSRvGH0zcxhU77PXFk3C7y/n8cSulVVvn05Aq6V30y+n4NFFC7DMqdufEqnHL1tMxm3lv3vgTSvnu3FONh2EZwyKnAbqfx+SmxH8g7kKdO7Ok0HRilJ709Xy3eJqMLRlN2h0b3RXA6XR9FRgks9ufF3zOjFCjDJKxsAA6DEAAAAAAAAAAAAAAAAwaTTWgYVYtqK1uG6X2fM3hgTVgeW4jQEoNum7cYy9XQlWnKCtOMk+OWr43PVsTgoT95Z8Vt8TRaR0NZbNeO/LNdVw5mM8Sfg0jkaPPoY+PxBLSHNG3x/ZaEs6bty3fg0GJ7P14ft1lyOV8embrMMS0g97KZ4/i2ILDzWTjbk8i2nRzzsio4khOdjkMa90fEYpYiT258tyFoQXXxG6UW9+r3Nv7eZXVE2Mwrpe8+7iMwxOtbyS+olGnG+UZyfG2ZfGE7ZJQXmOgsfVZra7ciVOpd8LeX3YjTpJb83tb2scppL8iCxqlO7tmlt6jkq6a4Lgapzbdo3frzHMLompO2tkuZSsTZmpiE8o+uH8DuB0dKftS9mPF+8+i/aubNhg9FQp2v7Ut18/7UbFUW/eyXD7s0jEiUhKnSutSklGK2y9bWbOhTUUorcShBJJJWS2EzZKjMAABgAAAAAAAAAAAAAAAAAAAAAAAAarH6LUryh7MuH7ZdVx5mnnrQbU4tNeHjsZ1piwmrA46cIS96EX3IhPQOGn+xJ8rr5HWVMHCV7xjnvSSfiLy0ZH9ra8155kOBSkcnLsnT/Y5LpK/zRKHZprZJ96R0NTB1Fss+af0ZiCn8M/BkOBXY0n+4J/GvD8mVoCfxeR0MXP4ZeAPX+GXgxdQ7Gih2cttkM0tDU4tXbb5j8oz+GXmWUsFLa7Lvv8AIagJyF6dCEdiQ5CM5ZJaq4v7F1DCKLu83x+yGjRRJbsrpUlH6stACxAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGGAAIAAAEMAABiMgADAAAAAAAAAAAAAAAAA//Z"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Mirosław",
                    LastName = "Kowalski",
                    Birthdate = new System.DateTime(2000, 1, 1),
                    Studies = "Ble",
                    Avatar = ""
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Senior",
                    LastName = "Java",
                    Birthdate = new System.DateTime(1900, 1, 1),
                    Studies = "Ble",
                    Avatar = ""
                }
            };
        }
        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(e => e.ID == id);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public bool Remove(int id)
        {
            return students.Remove(students.FirstOrDefault(e => e.ID == id));
        }
    }
}
