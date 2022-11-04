# Simple-Discrete-Event-Simulation

Use C# Winform to simulate the simple discrete event system

##  Simple Inventory System

模擬簡單的存貨系統。

### 存貨政策(Review policy)

系統每期會檢視存貨水平，倘若存貨水平低於**Minimum inventory level**則會立刻補貨至**Maximum inventory level**水平。

### 營運成本(Operation cost)

- Item Cost。訂貨的單位成本。
- Setup Cost。每次訂貨的固定成本。
- Holding Cost。持有存貨的單位成本。
- Shortage Cost。缺貨成本的單位成本。

### 系統的基本假設

* **未消化訂單(back ordering)是被允許的**。意味客戶已經下單，但交期延後，因此存貨水平有可能降至負的，此時缺貨成本(Shortage cost)會發生。
* **不會有延遲交貨( No delivery lag)**。向廠商訂購，廠商會立刻配送項目。這是不切實際的假設，在未來更為複雜的存貨模擬系統會被移除。
* 每期的需求量服從常態分布。
* 最初以及最後的存貨水平需為**Maximum inventory level**。

### 系統運作截圖

![image](https://user-images.githubusercontent.com/42717512/199896008-59725382-f677-4507-ae94-3b04d810f15d.png)

![image](https://user-images.githubusercontent.com/42717512/199896036-bf60de54-0f70-4c8f-ae15-6854dd2a0c97.png)

## Single -Server Queue
模擬單一server的服務系統

### 系統假設

1.	先進先出原則。每個job依照抵達時間先後處理，並且job抵達的順序和完成服務的順序一致。
2.	服務是conservative。只要有job在服務系統內，server就是處於服務狀態，不會閒置。一個job抵達的那刻，倘若隊列沒有job，server會立刻提供該job服務，並且在服務結束後server立刻提供服務給下一個job，中間不會有絲毫停頓。

### 程式截圖
![image](https://user-images.githubusercontent.com/42717512/113428023-a3948180-9408-11eb-9b2b-18eff4e33152.png)
![image](https://user-images.githubusercontent.com/42717512/113428105-c32baa00-9408-11eb-98d7-f408148af7e8.png)




