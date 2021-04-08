<<<<<<< HEAD
# Simple-Discrete-Event-Simulation

Use c# Winform to simulate the simple discrete event system

## Single Server Queue System

 

The application simulates the single server processes the job one after the other. In this case, the arrived jobs line up in a queue and are served on a FCFS (first come first served) discipline.

A service time factor is provided to define the proficiency of the server. The required process time for a job is therefore the service time of the job multiplied by the factor.

=======
# Simple Discrete Event Simulation
Use c# to simulate the simple discrete event

## Single -Server Queue
模擬單一server的服務系統，且基於以下兩點假設
1.	先進先出原則。每個job依照抵達時間先後處理，並且job抵達的順序和完成服務的順序一致。
2.	服務是conservative。只要有job在服務系統內，server就是處於服務狀態，不會閒置。一個job抵達的那刻，倘若隊列沒有job，server會立刻提供該job服務，並且在服務結束後server立刻提供服務給下一個job，中間不會有絲毫停頓。

### 程式截圖
![image](https://user-images.githubusercontent.com/42717512/113428023-a3948180-9408-11eb-9b2b-18eff4e33152.png)
![image](https://user-images.githubusercontent.com/42717512/113428105-c32baa00-9408-11eb-98d7-f408148af7e8.png)
>>>>>>> 2edef8ccd6124c9459e177378a83c9ccbd0a62ec


