# Project1
1:ความเป็นมาของโปรแกรม

โปรแกรมนี้ถูกพัฒนาขึ้นเพื่อแก้ไขปัญหาที่เกิดขึ้นในร้านซักผ้า
โดยปัญหาที่พบคือการจัดการคิวของลูกค้าที่มาใช้บริการซักผ้าโดยไม่มีระบบที่ช่วยในการจัดการคิวอย่างเป็นระบบ
โดยโปรแกรมนี้จะมาช่วยในเรื่องการจัดคิวทำให้เป็นระเบียบ


2:วัตถุประสงค์ของโปรแกรม
วัตถุประสงค์ของโปรแกรมนี้เป็นการช่วยเพิ่มประสิทธิภาพในการจัดการร้านซักผ้าด้วยการทำคิวและการจัดการเครื่องซักผ้าอย่างมีประสิทธิภาพ 
โดยมีวัตถุประสงค์หลักคือ

ลดเวลารอคิวของลูกค้า: โปรแกรมช่วยให้การจัดการคิวของลูกค้าเป็นไปอย่างมีระเบียบและรวดเร็ว
ลดเวลารอคิวของลูกค้าที่มาใช้บริการซักผ้าในร้านซักผ้า

เพิ่มประสิทธิภาพในการทำงานของร้านซักผ้า: โดยการจัดการคิวและการทำงานของเครื่องซักผ้าอย่างมีประสิทธิภาพ
ร้านซักผ้าสามารถทำงานได้อย่างเต็มประสิทธิภาพและสามารถรับลูกค้าเพิ่มเติมได้โดยไม่เสียเวลา

classdiagram:

classDiagram
    class QueueItem {
        + string CustomerName
        + int ClothesCount
        + bool IsMachineFull
        + LaundryQueueItem(string customerName, int clothesCount)
    }

    class washingMachine {
        + int MachineNumber
        + bool IsAvailable
        + Label StatusLabel
        + void StartLaundry(LaundryQueueItem queueItem)
        + void FinishLaundry()
        + LaundryMachine(int machineNumber)
    }

    class Queue {
        - Queue<LaundryQueueItem> queue
        + void Enqueue(LaundryQueueItem item)
        + LaundryQueueItem Dequeue()
        + bool IsEmpty()
        + LaundryQueueItem Peek()
    }

    QueueItem --* LaundryQueue
    QueueItem "1" --* "3" LaundryMachine : Uses