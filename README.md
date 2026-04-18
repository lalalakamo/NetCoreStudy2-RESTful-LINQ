觀念建立
1. 為避免不同開發風格導致Controller function命名雜亂 restful風格統一各function的寫法規則
   以本專案為例
   GET方法:
     api/HelloWorld:傳回List中所有HelloWorld資料
     api/HelloWorld/1:傳回ID為1的HelloWorld資料HelloWorld1
   POST方法:
     api/HelloWorld value=4:新增HelloWorld4資料
   PUT方法:
     api/HelloWorld/1 value=5:將ID為1的HelloWorld資料HelloWorld1改為HelloWorld4
   Delete方法:
     api/HelloWorld/1:刪除ID為1的HelloWorld資料HelloWorld1
