#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;
const float massPass=0.07;//константа для маси пасажирів(тони)
class Trip
{
protected://змінні до яких будуть мати доступ нащадки
    string company, nameShip, startPort, finishPort;
    int tonaj, vaga, kilkistPass;
public:
    Trip()//конструктор без параметра
    {
        this->nameShip="Defolt Name";
        this->company="Defolt";
        this->tonaj = 999999;
        this->startPort="City 1";
        this->finishPort="City 2";
        this->vaga = 900;
        this->kilkistPass=900;
    }
    Trip(string nameShip, string startPort, string finishPort, int kilkistPass, int tonaj, string company)
    {
        this->startPort=startPort;
        this->finishPort=finishPort;
        this->kilkistPass=kilkistPass;
        this->nameShip=nameShip;
        this->tonaj=tonaj;
        this->company=company;
        vaga=kilkistPass*massPass;
    }
    //сетери і гетери
    void setMassa(int tonaj){this->tonaj=tonaj;}
    void setNameShip(string nameShip){this->nameShip=nameShip;}
    void setCompany(string company){this->company=company;}
    void setStart(string startCity){this->startPort=startPort;}
    void setFinish(string finishCity){this->finishPort=finishPort;}
    void setKilkist(int kilkistPass) {kilkistPass=kilkistPass;}
    string getCompany(){return company;}
    string getNameShip(){return nameShip;}
    string getStart(){return startPort;}
    string getFinish(){return finishPort;}
    int getMassa(){return tonaj;}
    int getKilkist() {return kilkistPass;}
    int getVaga(){return vaga;}
    int overweight() const//розрахунок перевантаження
    {
        if(massPass*kilkistPass>tonaj)  {return 1;} else{return 0;}
    }
    void Print()//вивід інформації
    {
        //вивід на дисплей і у файл  пункти призначення, куди пароплав не прибуде, тому що перевантажений, а також назву компанії, що здійснює таку перевозку.
        if(overweight() == 1)
        {
            cout<<"Корабель: "<<getNameShip()<<" Від компанії: "<<getCompany()<<endl;
            cout<<" Мав відправлятися з порту: "<<getStart()<<" до порту: "<<getFinish()<<endl;
            cout<<"Проте цей рейс відмінили, адже корабель перевантажений"<<endl;
        }
    }
    ~Trip(){}//деструктор
    friend ofstream& operator <<(ofstream& t, Trip& w); // запис у файл
    friend ifstream& operator >>(ifstream& t, Trip& w);//виведення з файлу
};
class File : public Trip//клас роботи з файлом
{
private:
    Trip* NewShip;//створення нового елемента класу
    int counter = 0;//поточна довжина списку
    int maxCounter;// максимальна довжина списку
public:
    void SortAlphabet(Trip* NewShip)//сортування за алфавітом
    {
        for (int i = 0; i < counter; i++)
        {
            Trip* first_ele = &NewShip[i];
            for (int j = i + 1; j < counter; j++)
            {
                if(NewShip[i].getNameShip() > first_ele[j].getNameShip())
                {
                    swap(NewShip[i], NewShip[j]);
                }
            }
        }
    }
    File (int maxCounter)// Створення списку максимальногоx розміру
    {
        this->maxCounter = maxCounter;
        NewShip = new Trip[maxCounter]; // виділення пам'яті для списку
        counter = 0; //обнулення списку
    }
    ~File()
    {
        if (maxCounter > 0)
            delete[] NewShip; // звільнення пам'яті
    }
    bool Empty()//Перевірка на пустоту
    {
        return counter == 0;
    }
    int Counter()//Розрахунок кількості елементів списку
    {
        return counter;
    }
    bool Full()// Перевірка на повноту списку
    {
        return counter == maxCounter;
    }
    //Функція додавання до списку
    void AddInfo(string nameShip, string startPort, string finishPort, int kilkistPass, int tonaj, string company)
    {
        if (!Full())//Перевірка на повноту списку
        {
            NewShip[counter++] = Trip(nameShip, startPort, finishPort, kilkistPass, tonaj, company);
        }
    }
    void DeleteElementFromFile(int  del)//Видалення елементу зі списку за номером
    {
        Trip fordelete;
        cout << "Введiть номер корабля за списком для виделення зі списку" << endl;
        if (!Empty()) // Якщо список заповнений
        {
            Trip fordelete = NewShip[del];//Перезапис першого елементу списку
            for (int i = del; i < counter; i++)//зсув списку
                NewShip[i - 1] = NewShip[i];
            counter--;
        }
    }
    void ReadFile()//читання файлу
    {
        int kilkistSTR = 0;
        string str;
        ifstream fin("in.txt");
        if (fin) {
            while (!fin.eof())
            {
                getline(fin, str, '\n');
                kilkistSTR++;
            }
            fin.clear();
            fin.seekg(0);
            for (int i = 0; i < kilkistSTR - 1; i++)//зчитування елементі з файлу
            { fin>>nameShip; fin>>startPort; fin>>finishPort; fin>>kilkistPass; fin>>tonaj; fin>>company;
                if (!Full())//Запис якщо список не заповнений
                {
                    NewShip[counter++] = Trip(nameShip, startPort, finishPort, kilkistPass, tonaj, company);
                }
            }
            SortAlphabet(NewShip);//виклик сортування
            PrintFinal();//вивід одразу інформації з файлу
            fin.close();//закриття файлу
        }
    }
    void Write()//Запис поточного списку до файлу
    {
        ofstream filex("in.txt");
        for (int i = 0; i < counter; i++) 
        {
            filex << NewShip[i];
            cout << endl;
        }
        filex.close();
    }
    void PrintFinal()//Функція, що виводить список
    {
        cout << "Кораблі, що перевантажені" << endl;
        SortAlphabet(NewShip);
        int j = 1;
        for (int i = 0; i < counter; i++)  
        {
            if (NewShip[i].overweight() == 1) 
            {
                cout << j++ << ") ";
                NewShip[i].Print();
                cout << endl;
            }
        }
    }

};
ofstream& operator <<(ofstream& t, Trip& w)//запис у файл
{
    t << w.nameShip << " " << w.startPort << " " << w.finishPort << " " << w.kilkistPass << " " << w.tonaj << " " << w.company << endl;
    return t;
}
ifstream& operator >>(ifstream& t, Trip& w)//читання з файлу
{
    t >> w.nameShip;
    t >> w.startPort;
    t >> w.finishPort;
    t >> w.kilkistPass;
    t >> w.tonaj;
    t >> w.company;
    return t;
}
int main()
{
    system("CHCP 65001");
    int size = 10, del, kilkistPass, tonaj;
    string nameShip, startPort, finishPort, company;
    int MenuNum = 0;
    bool flag = true;
    File* NewShip = new File(size);
    cout << "\tПочаток   роботи" << endl;
    cout << "\t СПИСОК ПУСТИЙ\n\n\n" << endl;
    while (flag) 
        {
          cout << "1)Вивести поточний список перевантажених кораблів" << endl;
          cout << "2)Додати корабель до списку" << endl;
          cout << "3)Видалити перевантажений корабель" << endl;
          cout << "4)Записати поточний список до файлу" << endl;
          cout << "5)Заповнити список з файлу" << endl;
          cout << "6)Вийти з програми " << endl;
          cin >> MenuNum;
          switch (MenuNum)
        {
            case 1:
                NewShip->PrintFinal();
                break;
            case 2:
                cout << "\tВведіть дані для додання нового пароплаву" << endl;
                cout << "Введіть назву пароплаву" << endl;
                cin >> nameShip;
                cout<<"Введіть тонаж пароплаву"<<endl;
                cin>>tonaj;
                cout<<"Введіть назву компанії тримаючої пароплав"<<endl;
                cin>>company;
                cout << "Введіть місто з якого він відпливає" << endl;
                cin >> startPort;
                cout << "Введіть місто пробутя" << endl;
                cin >> finishPort;
                cout << "Введіть кількість пасажирів" << endl;
                cin >> kilkistPass;
                NewShip->AddInfo(nameShip, startPort, finishPort, kilkistPass, tonaj, company);
                break;
            case 3:
                cout << "\tВведіть номер корабля у списку, який ви бажаєте видалити" << endl;
                cin >> del;
                NewShip->DeleteElementFromFile(del);
                break;
            case 4:
                NewShip->Write();
                break;
            case 5:
                NewShip->ReadFile();
                break;
            default:
                cout << "\tРОБОТУ ЗАВЕРШЕНО";
                flag = false; break;
        }
    }
    return 0;}
