using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleTeam8.Controllers
{
    public class FolderController
    {
        //Thêm 1 folder vào database(Hùng)
        public static bool AddFolder(ClassFolder folder)
        {
            try
            {
                using (var _context = new DBFolderContext())
                {
                    //foreach(var file in folder.listfile)
                    //{
                    //    var filedb = (from f in _context.tbFiles
                    //                  where f.namefile == file.namefile
                    //                  select f).Single();
                    //    filedb.folder.Add(folder);
                    //}
                    _context.tbFolders.Add(folder);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //public static bool AddFile(ClassFolder folder, ClassFile file)
        //{
        //    try
        //    {
        //        using (var _context = new DBFolderContext())
        //        {
        //            _context.tbFiles.AddOrUpdate(file);//err: filedb null
        //            var filedb = (from f in _context.tbFiles
        //                          where f.namefile == file.namefile
        //                          select f).SingleOrDefault();
        //            filedb.folder.Add(folder);
        //            _context.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //Hiển thị list folder khi mở lại form(Hùng)
        public static List<ClassFolder> getListFolder()
        {
            using (var _context = new DBFolderContext())
            {
                //var folder = (from f in _context.tbFolders.AsEnumerable()
                //              select new
                //              {
                //                  foldername = f.namefolder,
                //                  filename = f.listfile,
                //              })
                //              .Select(x => new ClassFolder
                //              {
                //                  namefolder = x.foldername,
                //                  listfile = x.filename,
                //              }).ToList();
                var folder = (from f in _context.tbFolders
                              select f).ToList();
                return folder;

            }
        }
        //Lấy folder trong database dựa vào tên
        public static ClassFolder getFolder(string namefolder)
        {
            using (var _context = new DBFolderContext())
            {
                var folder = (from f in _context.tbFolders
                              where f.namefolder == namefolder
                              select f).ToList();
                if (folder.Count == 1)
                {
                    return folder[0];
                }
                else
                    return null;

            }
        }
        //Thay đổi tên của folder trong database

        public static bool UpdateFolder(ClassFolder folder, ClassFolder newFolder)
        {
            //using (var _context = new DBFolderContext())
            //{
            //    _context.tbFolders.AddOrUpdate(folder);
            //    _context.SaveChanges();
            //    return true;
            //}
            //using (var _context = new DBFolderContext())
            //{
            //    var userdb = _context.tbFolders.SingleOrDefault(u => u.namefolder == folder.namefolder);
            //    userdb.namefolder = newName;
            //    _context.SaveChanges();
            //    return true;


            //}
            using (var _context = new DBFolderContext())
            {
                if (_context.tbFolders.Any(e => e.namefolder == newFolder.namefolder))
                {
                    MessageBox.Show("Name already exists in the Database");
                }
                else
                {
                    var nameToUpdate = _context.tbFolders.SingleOrDefault(e => e.namefolder == folder.namefolder);
                    if (nameToUpdate != null)
                    {
                        nameToUpdate.namefolder = newFolder.namefolder;
                        _context.SaveChanges();
                    }
                }
                return true;
            }
        }
        //Xóa 1 folder trong database
        public static bool DeleteFolder(ClassFolder folder)
        {
            using (var _context = new DBFolderContext())
            {
                var dbfolder = (from u in _context.tbFolders
                                where u.namefolder == folder.namefolder
                                select u).SingleOrDefault();
                foreach (var file in dbfolder.listfile)
                {
                    foreach (var u in file.folder)
                    {
                        if (u.namefolder == folder.namefolder)
                        {
                            file.folder.Remove(u);
                            break;
                        }
                    }
                }
                _context.tbFolders.Remove(dbfolder);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
