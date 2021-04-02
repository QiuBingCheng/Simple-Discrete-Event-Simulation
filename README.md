# Simple Discrete Event Simulation
Use c# to simulate the single-server queue.

## Single -Server Queue
模擬單一server的服務系統，且基於以下兩點假設
1.	先進先出原則。每個job依照抵達時間先後處理，並且job抵達的順序和完成服務的順序一致。
2.	服務是conservative。只要有job在服務系統內，server就是處於服務狀態，不會閒置。一個job抵達的那刻，倘若隊列沒有job，server會立刻提供該job服務，並且在服務結束後server立刻提供服務給下一個job，中間不會有絲毫停頓。

### 程式截圖
![image](https://user-images.githubusercontent.com/42717512/113428023-a3948180-9408-11eb-9b2b-18eff4e33152.png)
![image](https://user-images.githubusercontent.com/42717512/113428105-c32baa00-9408-11eb-98d7-f408148af7e8.png)


