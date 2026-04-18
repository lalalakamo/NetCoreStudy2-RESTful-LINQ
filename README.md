###RESTful練習

為避免不同開發風格導致Controller function命名雜亂 restful風格統一各function的寫法規則

### 以本專案HelloWorld為例：
| HTTP Method | 路徑 (Route) | 功能描述 | 範例 |
| :--- | :--- | :--- | :--- |
| **GET** | `api/HelloWorld` | 取得清單中所有資料 | 傳回所有 HelloWorld 列表 |
| **GET** | `api/HelloWorld/{id}` | 取得指定 ID 的單筆資料 | 傳回 ID=1 的資料 |
| **POST** | `api/HelloWorld` | 新增資料 | 新增 HelloWorld4 資料 |
| **PUT** | `api/HelloWorld/{id}` | 更新指定 ID 的資料內容 | 將 ID=1 的標題改為 HelloWorld4 |
| **DELETE** | `api/HelloWorld/{id}` | 刪除指定 ID 的資料 | 刪除 ID=1 的資料 |

### LINQ練習:
*改寫原本的HelloWorld API專案，並遵守RESTful撰寫風格
* **查詢語法 (Query Syntax)** 與 **方法語法 (Method Syntax)** 的練習。
* 搭配 **Lambda 表達式** 提高程式碼簡潔度。

### 2. 介面與回傳型別 (Interface & Return Type)
* **`IEnumerable`**: 
    * 集合具有「唯讀」特性。
    * 由於延遲執行 (Deferred Execution) 且不需負擔 List 的額外操作，效能較為輕量。
* **`IActionResult` (核心價值：明確的狀態碼控制)**:
    * 若直接回傳物件，遇到 `null` 時前端會收到 `204 No Content`，開發者會失去對 HTTP 語義的精準控制。
    * 使用 `Ok()`、`NotFound()` 或 `CreatedAtAction()` 等，能確保 API 符合標準通訊協定。
  
### 3. LINQ 搜尋方法差異比較
* **`Where`**:
    * 找不到對應資料時會回傳「空集合」而非 `null`。
    * **注意：** 無法直接透過 `== null` 來判斷是否有資料。
* **`FirstOrDefault` vs `SingleOrDefault`**:
    * 兩者在找不到資料時皆會回傳 `null`。
    * **`First` 系列**: 掃描到第一筆符合條件的資料即停止，**效能較佳**。
    * **`Single` 系列**: 會掃描完整個集合以確保「唯一性」，若發現多筆符合則會報錯，**安全性較高**。

### 4. 參照型別 (Reference Type) 的特性
* 本實作中的集合採用 `class` 定義。
* **特點：** 在執行 `update.title = "HelloWorld2"` 時，由於操作的是記憶體位址，會直接反映並更新原始集合內的資料。
