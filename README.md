# Project1
1:�������Ңͧ�����

��������١�Ѳ�Ң��������䢻ѭ�ҷ���Դ������ҹ�ѡ���
�»ѭ�ҷ�辺��͡�èѴ��ä�Ǣͧ�١��ҷ�������ԡ�ëѡ�����������к�������㹡�èѴ��ä�����ҧ���к�
������������Ҫ��������ͧ��èѴ��Ƿ����������º


2:�ѵ�ػ��ʧ��ͧ�����
�ѵ�ػ��ʧ��ͧ���������繡�ê�����������Է���Ҿ㹡�èѴ�����ҹ�ѡ��Ҵ��¡�÷Ӥ����С�èѴ�������ͧ�ѡ������ҧ�ջ���Է���Ҿ 
�����ѵ�ػ��ʧ����ѡ���

Ŵ�����ͤ�Ǣͧ�١���: �������������èѴ��ä�Ǣͧ�١���������ҧ������º����Ǵ����
Ŵ�����ͤ�Ǣͧ�١��ҷ�������ԡ�ëѡ������ҹ�ѡ���

��������Է���Ҿ㹡�÷ӧҹ�ͧ��ҹ�ѡ���: �¡�èѴ��ä����С�÷ӧҹ�ͧ����ͧ�ѡ������ҧ�ջ���Է���Ҿ
��ҹ�ѡ�������ö�ӧҹ�����ҧ�������Է���Ҿ�������ö�Ѻ�١�������������������������

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