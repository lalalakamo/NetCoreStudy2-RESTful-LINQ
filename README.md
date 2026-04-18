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

LINQ練習:
改寫原本的HelloWorld API，並遵守RESTful撰寫風格

觀念建立

介面Interface: 可供查詢的集合具有唯獨的特性所以也比較輕量 本實作用到的是IEnumerable
合約IActionResult: 如果直接傳回hellos如果遇到null前端會收到204 no content的錯誤碼，後端則會失去對 HTTP 語義的控制權。
使用 IActionResult 的核心價值在於 「明確的 HTTP 狀態碼傳遞」
IActionResult可傳回Ok()、NotFound()等狀態，可附加要傳回的物件
SingleOrDefault、FirstOrDefault與Where: Where在找不到索引時仍然會回傳空集合，會無法觸發null的判斷
SingleOrDefault、FirstOrDefault則會回傳一個真正的null，Single與First的差別在於Single會掃完整個集合確保只有那一筆_
主鍵的資料，First則只要掃到一筆就會停下 Single較安全，First較不耗能
本實作的集合是採用class 參照型別 (Reference Type)的方式，在執行update.title = "HelloWorld2"時會直接更新集合內的資料
