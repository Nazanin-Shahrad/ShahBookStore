# ShahBookStore


Nov 4th , 2021 Thursday , 8 am  
I started working on ASP.net assignment2 part1 
1-create a new project 
2-ASP.net core web app MVC  ---individual user account  ----enable razor runtime compliation 
3-there is a 00000..cs file in DATA\Migration  
There is another ApplicationDbContext for accessing database  
4- set the git to upload(push) to github  ////this part was very annoying on MAC , there is not any git menu , so I had to make this project 7 timessssssssssssss 
5-I picked Slate theme from bootswatch.com and modify the _layout file to  bootstap.css 
Change the navbar class  
And remove text-dark 
6- add some links to use 3rd part tools such as font awesome … in header and bottom of body  
7-change some part of _layout , add dropdown menu8 
8-add 3 new projects(.NTE core class library) 
 First time added some other projects by mistake  
ShahsBooks.DataAccess 
SHahsBooks.Utinily 
ShahsBooks.Models 
9- copy data folder from main project and paste to. DataAccess 
10- install some packages  
Microsft.EntityFrameworkcore.Relational------------------------- first time I installed wrong version 
Microsft.EntityFrameworkcore.sqlserver 
Identity.EntityFrameworkCore   
11- delete migrate folder 
12- delete Class1.cs from projects 
13- build project 
14- rename model folder to viewModels 
15-Modify startup.cs service AddContext 
16- run the application 
17- modify homeController 
18- update github 
 
 
 
18 NOV 2021  
This part resolved after 7 trys , at last I had to change my laptop to complete it as I couldn’t work with mac I started this part 9:00 am

1-appsetting.json changed in to Database=ShahBookStore  
2- in PM console run  ---::--- 
 add-migration AddDefaultIdentiryMigration 
Defauly project should be ShahsBooks.Dataaccess      very important 
 
 202111182 Nov 4th , 2021 Thursday , 8 am  
I started working on ASP.net assignment2 part1 
1-create a new project 
2-ASP.net core web app MVC  ---individual user account  ----enable razor runtime compliation 
3-there is a 00000..cs file in DATA\Migration  
There is another ApplicationDbContext for accessing database  
4- set the git to upload(push) to github  ////this part was very annoying on MAC , there is not any git menu , so I had to make this project 7 timessssssssssssss 
5-I picked Slate theme from bootswatch.com and modify the _layout file to  bootstap.css 
Change the navbar class  
And remove text-dark 
6- add some links to use 3rd part tools such as font awesome … in header and bottom of body  
7-change some part of _layout , add dropdown menu8 
8-add 3 new projects(.NTE core class library) 
 First time added some other projects by mistake  
ShahsBooks.DataAccess 
SHahsBooks.Utinily 
ShahsBooks.Models 
9- copy data folder from main project and paste to. DataAccess 
10- install some packages  
Microsft.EntityFrameworkcore.Relational------------------------- first time I installed wrong version 
Microsft.EntityFrameworkcore.sqlserver 
Identity.EntityFrameworkCore   
11- delete migrate folder 
12- delete Class1.cs from projects 
13- build project 
14- rename model folder to viewModels 
15-Modify startup.cs service AddContext 
16- run the application 
17- modify homeController 
18- update github 
 
 
 
18 NOV 2021  
This part resolved after 7 trys , at last I had to change my laptop to complete it as I couldn’t work with mac 
1-appsetting.json changed in to Database=ShahBookStore  
2- in PM console run  ---::--- 
 add-migration AddDefaultIdentiryMigration 
Defauly project should be ShahsBooks.Dataaccess      very important 
 
 202111118205035_AddDefualtIdentiryMigration.cs

3- database should be updated  
Update-database 
3- database should be updated  
Update-database 

4- add the new table to the DB category model and push it
5-add new class into ViewModel --------- category.cs
6-add-migration AddCtegoryToDb
7- new migration and update database

20211118215951_AddCategoryTodoDb




8-Implement repository /IRepository
9-modify Category class to do all CRUD
10-**** important *** add class repository.cs
11-CategoryRepository and ICategoryRepository.cs
It should be point to ApplicationDbContext. ------- using ShahsBooks.Models top of this file
12-bulid --error
13-SP_Call.cs and its related interface 
14-connection to Database shound be implemented
15-github




Part 2 ///// I started on Nov 28 

1-I modifies Startup.cs with UnitOfWork
2-ass a new MVC controller  --Area/Admin. 
3- in categoryController I forgot to add [Area(“Admin”)] *****
4-New forlder Category ( include index and Upsert files)
5-add Category in _Layout 
6-modify fornt awesome ---------------- it didn’t workd first
7-add javascript part intocategory.cs in wwwroot and also @section should be added in the botoom of index file
8-Edit and Delete --in Upsert file
9-create a partial view for edit _CreateAndBAckToListButton and _EditAndBAckToListButton

20211112815951_AddCategoryTodoDb



Part3 dec 1
1-	In Area>Admin controllers to perform CURD
2-	Add IWebHostEnvironment 
3-	Creating a viewmodel in the model project Category and CoverType
4-	Modify productVM class
5-	Adding asp.netcore.mvc.viewfeature pachakge
6-	GetAll(includePeroperties “Category, coverType” in productController should be added
7-	20211201222246_AddCoverTypeToDb.cs



Continue Dec 2

8-	For product ---- create index and Upsert
9-	Upsert should be modified I didn’t change Category into CoverType in 
 This part 

Migration 20211202111635_addProductToDb
20211202113203







Nov 4th , 2021 Thursday , 8 am  
I started working on ASP.net assignment2 part1 
1-create a new project 
2-ASP.net core web app MVC  ---individual user account  ----enable razor runtime compliation 
3-there is a 00000..cs file in DATA\Migration  
There is another ApplicationDbContext for accessing database  
4- set the git to upload(push) to github  ////this part was very annoying on MAC , there is not any git menu , so I had to make this project 7 timessssssssssssss 
5-I picked Slate theme from bootswatch.com and modify the _layout file to  bootstap.css 
Change the navbar class  
And remove text-dark 
6- add some links to use 3rd part tools such as font awesome … in header and bottom of body  
7-change some part of _layout , add dropdown menu8 
8-add 3 new projects(.NTE core class library) 
 First time added some other projects by mistake  
ShahsBooks.DataAccess 
SHahsBooks.Utinily 
ShahsBooks.Models 
9- copy data folder from main project and paste to. DataAccess 
10- install some packages  
Microsft.EntityFrameworkcore.Relational------------------------- first time I installed wrong version 
Microsft.EntityFrameworkcore.sqlserver 
Identity.EntityFrameworkCore   
11- delete migrate folder 
12- delete Class1.cs from projects 
13- build project 
14- rename model folder to viewModels 
15-Modify startup.cs service AddContext 
16- run the application 
17- modify homeController 
18- update github 
 
 
 
18 NOV 2021  
This part resolved after 7 trys , at last I had to change my laptop to complete it as I couldn’t work with mac I started this part 9:00 am

1-appsetting.json changed in to Database=ShahBookStore  
2- in PM console run  ---::--- 
 add-migration AddDefaultIdentiryMigration 
Defauly project should be ShahsBooks.Dataaccess      very important 
 
 202111182 Nov 4th , 2021 Thursday , 8 am  
I started working on ASP.net assignment2 part1 
1-create a new project 
2-ASP.net core web app MVC  ---individual user account  ----enable razor runtime compliation 
3-there is a 00000..cs file in DATA\Migration  
There is another ApplicationDbContext for accessing database  
4- set the git to upload(push) to github  ////this part was very annoying on MAC , there is not any git menu , so I had to make this project 7 timessssssssssssss 
5-I picked Slate theme from bootswatch.com and modify the _layout file to  bootstap.css 
Change the navbar class  
And remove text-dark 
6- add some links to use 3rd part tools such as font awesome … in header and bottom of body  
7-change some part of _layout , add dropdown menu8 
8-add 3 new projects(.NTE core class library) 
 First time added some other projects by mistake  
ShahsBooks.DataAccess 
SHahsBooks.Utinily 
ShahsBooks.Models 
9- copy data folder from main project and paste to. DataAccess 
10- install some packages  
Microsft.EntityFrameworkcore.Relational------------------------- first time I installed wrong version 
Microsft.EntityFrameworkcore.sqlserver 
Identity.EntityFrameworkCore   
11- delete migrate folder 
12- delete Class1.cs from projects 
13- build project 
14- rename model folder to viewModels 
15-Modify startup.cs service AddContext 
16- run the application 
17- modify homeController 
18- update github 
 
 
 
18 NOV 2021  
This part resolved after 7 trys , at last I had to change my laptop to complete it as I couldn’t work with mac 
1-appsetting.json changed in to Database=ShahBookStore  
2- in PM console run  ---::--- 
 add-migration AddDefaultIdentiryMigration 
Defauly project should be ShahsBooks.Dataaccess      very important 
 
 202111118205035_AddDefualtIdentiryMigration.cs

3- database should be updated  
Update-database 
3- database should be updated  
Update-database 

4- add the new table to the DB category model and push it
5-add new class into ViewModel --------- category.cs
6-add-migration AddCtegoryToDb
7- new migration and update database

20211118215951_AddCategoryTodoDb




8-Implement repository /IRepository
9-modify Category class to do all CRUD
10-**** important *** add class repository.cs
11-CategoryRepository and ICategoryRepository.cs
It should be point to ApplicationDbContext. ------- using ShahsBooks.Models top of this file
12-bulid --error
13-SP_Call.cs and its related interface 
14-connection to Database shound be implemented
15-github




Part 2 ///// I started on Nov 28 

1-I modifies Startup.cs with UnitOfWork
2-ass a new MVC controller  --Area/Admin. 
3- in categoryController I forgot to add [Area(“Admin”)] *****
4-New forlder Category ( include index and Upsert files)
5-add Category in _Layout 
6-modify fornt awesome ---------------- it didn’t workd first
7-add javascript part intocategory.cs in wwwroot and also @section should be added in the botoom of index file
8-Edit and Delete --in Upsert file
9-create a partial view for edit _CreateAndBAckToListButton and _EditAndBAckToListButton

20211112815951_AddCategoryTodoDb



Part3 dec 1
1-	In Area>Admin controllers to perform CURD
2-	Add IWebHostEnvironment 
3-	Creating a viewmodel in the model project Category and CoverType
4-	Modify productVM class
5-	Adding asp.netcore.mvc.viewfeature pachakge
6-	GetAll(includePeroperties “Category, coverType” in productController should be added
7-	20211201222246_AddCoverTypeToDb.cs



Continue Dec 2

8-	For product ---- create index and Upsert
9-	Upsert should be modified I didn’t change Category into CoverType in 
 This part 

Migration 20211202111635_addProductToDb
20211202113203









9 Nov 2021 5 am

1- shahBookStore ---> Area----> controller--->CategoryController.cs
 I just add #region API CALLS and     #endregion

2-shahBookStore ---> Area----> controller--->CoverTypeController.cs 
 add using using ShahsBooks.Utility;
add using Dapper;


            // this is for edit
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            coverType = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
            if (coverType == null)
            {
                return NotFound();
            }
            return View(coverType);
        }


error (SD.Proc_CoverType_Get) in covertypecontroller.cs

***
var parameter = new DynamicParameters();
                parameter.Add("@Name", coverType.Name);
***


  parameter.Add("@Id", coverType.Id);




                if (coverType.Id == 0)
                {
                    _unitOfWork.CoverType.Add(coverType);
			changed into this line -->(((((( _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Create, parameter);)))))
                }


----------------------------------------------

  else
                {
                    _unitOfWork.CoverType.Update(coverType);
                }


changed into this line -->((((((((((( else
                {
                    parameter.Add("@Id", coverType.Id);
                    _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Update, parameter);
                }))))))))))))))))
--------------------------------------------------


public IActionResult GetAll()
        {
            var allObj =_unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }

changed into this line -->((((((((((((((public IActionResult GetAll()
        {
            var allObj = _unitOfWork.SP_Call.List<CoverType>(SD.Proc_CoverType_GetAll, null);
            return Json(new { data = allObj });
        })))))))))))))))))

----------------------------------------

          public IActionResult Delete(int id)
        {
            var ObjFormDb = _unitOfWork.CoverType.Get(id);
            if (ObjFormDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CoverType.Remove(ObjFormDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

changed into this line -->((((((((((((((var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            var objFromDb = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Delete, parameter);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });)))))))))))))))))))))


---------------------------------------------

in file ProductController :

I add using System.IO;


public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)
            {
             
                if (product.Id > 0)
                {
                    _unitOfWork.Product.Add(product);

                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


changed into this form ((((((((((((((((

public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\products");
                    var extension = Path.GetExtension(files[0].FileName);

                    if (productVM.Product.ImageUrl != null)
                    {
                        // this is an edit and we need to remove old image
                        var imagePath = Path.Combine(webRootPath, productVM.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using(var filesStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    productVM.Product.ImageUrl = @"\images\products\" + fileName + extension;
                }
                else
                {
                    // update when they do not change the image
                    if (productVM.Product.Id != 0)
                    {
                        Product objFromDb = _unitOfWork.Product.Get(productVM.Product.Id);
                        productVM.Product.ImageUrl = objFromDb.ImageUrl;
                    }
                }

                if (productVM.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVM.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(productVM.Product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                productVM.CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
                productVM.CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
                if (productVM.Product.Id != 0)
                {
                    productVM.Product = _unitOfWork.Product.Get(productVM.Product.Id);
                }
            }
            return View(productVM);
        }


)))))))))))))))))))))))))))))
--------------------------------------------------



 public IActionResult Delete(int id)
        {
            var objFormDb = _unitOfWork.Product.Get(id);
            if(objFormDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Product.Remove(objFormDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }




changed into ((((((((((((((((((
public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDb.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
)))))))))))))))))))))))))









Add-migration 

20211209140040_AddValidationToProduct.Designer
20211209140125_AddCoverTypeToDb.Designer
20211209140206_AddStoredProcForCoverType.Designer
20211209140233_AddStoredProcForCoverType


ShahBooksStore/Area/Admin/view/category

upaert   @if(Model.Id != null) changed into ------------>  @if(Model.Id != 0)



ShahBooksStore/Area/Admin/view/CoverType

same in this file 



as soon as I did add-migration and change the database , i couldn't push to github and everything messed up






