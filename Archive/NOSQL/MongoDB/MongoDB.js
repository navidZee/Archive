show dbs // نمایش کل بانک ها

db.CollectionName.insert({ JSON }) // ثبت در کالکشن

show conlleciotns // نمایش تمام کالکشن ها-- db.getCollectionNames()

db.ColleciotnName.find().pretty()// نمایش تمام کالکشن ها به صورت JSON

db.ColleciotnName.find({ roles: 'admin' }).pretty()// شرط نمایش رول های کاربر

db.CollectionName.update({ شرط }, { $set: { Name: 'ARSALAN ' } })

db.CollecitonName.remove({ شرط })

db.users.remove({ "age": { $gt: 25 } }); db.users.remove({ "firstName": "Dariush" }, 1); //اولین سندی ک این شرط برقرار باشد

db.dropDatabase() //  برای حذف یک بانک‌اطلاعاتی، باید ابتدا باید وارد آن شده و سپس اقدام به حذف آن نماییم

db.users.drop();