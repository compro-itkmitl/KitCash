# KitCash

* This is a Project for computer programming 06016315
* โปรเจคนี้ เป็นส่วนหนึ่งของรายวิชา คอมพิวเตอร์โปรแกรมมิ่ง 06016315

#### KitCash is a shop assitstant program which will help you manage your own shop. KitCash may help you organize storing goods, selling and billing with Line notify (send to line function will send a bill to your LINE ID), it's also able to chose date time with range to get a report(bill) too. so....
#### KitCash เป็นโปรแกรม ที่จะคอยช่วยเหลือคุณในการจัดการร้านค้า. KitCash สามารถช่วยคุณจัดการสินค้าคงคลัง, การขายสินค้า และการรายงานผล ด้วย ฟังก์ชั่น send to line ผ่าน line notify จะสามารถส่งบิล ไปยังไลน์ของคุณได้ อีกทั้งยังสามารถ เลือกระยะเวลา ขอบเขต ที่ต้องการแสดงผลบิลได้อีกด้วย++ 
#### PLEASE ENJOY

# Installation
[DOWNLOAD: (https://github.com/compro-itkmitl/KitCash)]
**Requirements**
* a computer/pc/laptop with windows 7/8/10 os
##MADE BY
* c++, c#, MSSQL
* Visual Studio 2017
* Smart Install Maker
* Telek Reporting R2 2017
* Also use online/offline Database for storing data  
## ขั้นตอนการติดตั้ง
1. ทำการแตกไฟล์ ที่ทำการ download มาจาก github
2. เปิดโฟลเดอร์ Build-Only > Setup-File > *Setup.exe*
    - ![](Pics/Capture1.PNG)
3. ดับเบิ้ลคลิก แล้วเริ่มทำการติดตั้ง เลือกตำแหน่งที่ต้องการติดตั้ง application แล้วเลือก *Next*
4. เลือก Create a Desktop icon เพื่อสร้างไอคอนบน Desktop และ เลือก Create shortcut in start menu เพื่อสร้างทางลัดใน Start Menu แล้วเลือก *Next*
5. ทำการยืนยันตำแหน่งที่ต้องการติดตั้งแล้ว เลือก *Install*
6. ติดตั้ง Microsoft SQL Server 2016 LocalDB เพื่อใช้ฐานข้อมูล offline เลือก *Next*
7. เลือก *I accept the terms in the license agreement* แล้วเลือก *Next*
8. เลือก *Install*
9. เลือก *Finish* เพื่อสิ้นสุดการติดตั้ง Microsoft SQL Server 2016 LocalDB
10. เลือก *Finish* เพื่อสิ้นสุดการติดตั้ง KitCash
    - ![](Pics/ins-0.gif)
# Using KitCash - การใช้งาน KitCash
### KitCash มี 5 ฟังก์ชั่นหลักๆคือ 
1. ITEM_SALE ฟังก์ชั่นการขายสินค้า
    - ![](Pics/use3.png)
2. ITEM_ADD ฟังก์ชั่นการเพิ่มสินค้า
    - ![](Pics/use4.png)
3. ITEM_EDIT ฟังก์ชั่นการแก้ไขสินค้า
    - ![](Pics/use5.png)
4. ITEM_REPORT ฟังก์ชั่นการรายงานผล
    - ![](Pics/sl4.png)
5. USER ฟังก์ชั่นการเพิ่มข้อมูลพนักงาน และแก้ไขข้อมูลพนักงาน
    - ![](Pics/use6.PNG)
### การใช้งาน KitCash
1. เปิดโปรแกรม KitCash ขึ้นมา จะพบกับหน้าจอ Login ในที่นี้สามรถใช้ username: admin password: 1234 ได้เนื่องจากเป็น DEMO เมื่อทำการ login สำเร็จจะขึ้นหน้าต่างการแสดงผลว่า "สำเร็จ"
    - ![](Pics/login1.png)
    - ![](Pics/login2.png)
    - ![](Pics/login3.png)
2. เมื่อทำการ login เสร็จสิ้นจะแสดงหน้าต่าง ฟังก์ชั่น ITEM_SALE สำหรับขายสินค้า
    - ![](Pics/use3.png)
    - ฟังก์ชั่นการขายสินค้านั้นจะสามารถใช้ได้โดยการ
        1. กรอกรหัสสินค้า
        2. ใส่จำนวนที่ต้องการซื้อ
        3. กดเพิ่มสินค้า
        4. หากเลือกสินค้าจนเสร็จสิ้นแล้ว ให้กรอกรหัสลูกค้า และชื่อลูกค้า
        5. กดบันทึกการขาย เป็นอันเสร็จ
        *โดยใบเสร็จการซื้อขายซื้อขายจะถูกส่งไปยังฟังก์ชั่น Report*
3. หากต้องการ การรายงานผล ให้ไปยัง ฟังก์ชั่น ITEM_REPORT แล้วทำการเลือกวันที่ ที่ต้องการ การรายงานผล (หากเป็นวันเดียวกัน ให้วันตั้งต้นเป็นเมื่อวาน) แล้วกดแสดงผล และ แสดงยอด 
    - ![](Pics/sl4.png)
    - ![](Pics/sl5.png)
    - ![](Pics/sl6.png)
    - ![](Pics/sell7.PNG)
    - เมื่อทำการส่งเข้าไลน์ จะแสดงผลตามรูป
# Members
|  |ชื่อ|นามสกุล|GitHub Username|รหัสนักศึกษา|
|:-:|--|------|---------------|---------|
|![](Pics/onez.jpg)|Kitrawee|Phasukrojsin|[@nuengnakhap](https://github.com/nuengnakhap)|60070005|
|![](Pics/kim.jpg)|Khosit|Khositsrikunakorn|[@kimkho](https://github.com/kimkho)|60070008|
|![](Pics/phee.jpg)|Chayanin|Lumyong|[@azurelisz](https://github.com/azurelisz)|60070012|
# Special Thanks
* Asst Profressor Kitsuchart Pasupa
    - ![](Pics/ksc.jpg)
* Asst Profressor Panwit Tuwanut
    - ![](Pics/pw.jpg)
----------------------------------------
Thank you for Attentions

## Faculty of Information Technology 
## King Mongkut's Institute of Technology Ladkrabang
