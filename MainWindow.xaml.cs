using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;


namespace Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public class Seat {

   
        public bool isBooked { get; set; }
        public String passangerFirstName { get; set; }
        public String passangerLastName { get; set; }   
        public String PassangerMobileNumber  {get; set; }

        public String toolText  { get; set; } 
     
    }



    public partial class MainWindow : Window
    {
        static Seat[] seats = new Seat[20];
        

        bool IsALLSelected;

        bool IsDetailsValids = false;


        

        public MainWindow()
        {

            InitializeComponent();
            initalizeSeats();
            selectSeats();
            showList();
        }

        private void selectSeats()
        {
            

            resultLabel.Content = System.AppDomain.CurrentDomain.BaseDirectory;

            List<int> emptySeats = new List<int>();

            var XmlSerializerInt = new XmlSerializer(typeof(List<int>));
            using (var writer = new StreamWriter(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleDataInt.xml"))
            {
                XmlSerializerInt.Serialize(writer, emptySeats);
            }


            for (int i = 0; i < emptySeats.Count; i++)
            { 
               

                if (i != emptySeats.ElementAt(i))
                {
                    seats[i].isBooked = true;
                    //seats[i].personFirstName = "Mike";
                    //seats[i].personLastName = "Benjamin";
                    updateSeats();
                   

                }
            }
           
        }

        private void clearSeatsByName_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                
                if (seats[i].passangerFirstName == SelectorTextField.Text)
                {
                    seats[i].isBooked = false;
                    seats[i].passangerFirstName = "Not ";
                    seats[i].passangerLastName = "Reserved";
                    updateSeats();
                }
            }
        }

        private void initalizeSeats(bool selectAll)
        {
            for (int index = 0; index < 20; index++) {
                Seat seat = seats[index] = new Seat();
                if (selectAll)
                {
                    seat.isBooked = true;
                    seat.passangerFirstName = "Mike";
                    seat.passangerLastName = "Benjamin";
                }
                else {
                    seat.isBooked = false;
                    seat.passangerFirstName = "Not ";
                    seat.passangerLastName = "Reserved";
                }
                Label temp = new Label();
                temp = selectLabel(index);
                if (seat.isBooked)
                {
                    
                    temp.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");

                }
                else if (!seat.isBooked)
                {
             
                    temp.Background = (Brush)new BrushConverter().ConvertFromString("#6fff59");

                }
            }
        }
        private void initalizeSeats()
        {
            for (int index = 0; index < 20; index++) {
                Seat seat = seats[index] = new Seat();
                
            }
        }

        private void updateSeats()
        {
            for (int index = 0; index < 20; index++)
            {
                
               if (seats[index].isBooked)
                {
                    Label temp = new Label();
                    temp = selectLabel(index);
                    temp.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");

                }

                else if (!seats[index].isBooked)
                {
                    Label temp = new Label();
                    temp = selectLabel(index);
                    temp.Background = (Brush)new BrushConverter().ConvertFromString("#6fff59");

                }
        


            }
        }

 
        private string seatName (int index)
        {
            string label = "";
            switch (index)
            {

                case 0:
                    label = "A";
                    break;

                case 1:
                    label = "B";
                    break;

                case 2:
                    label = "C";
                    break;

                case 3:
                    label = "D";
                    break;

                case 4:
                    label = "E";
                    break;

                case 5:
                    label = "F";
                    break;

                case 6:
                    label = "G";
                    break;

                case 7:
                    label = "H";
                    break;

                case 8:
                    label = "I";
                    break;

                case 9:
                    label = "J";
                    break;

                case 10:
                    label = "K";
                    break;

                case 11:
                    label = "L";
                    break;

                case 12:
                    label = "M";
                    break;

                case 13:
                    label = "N";
                    break;

                case 14:
                    label = "O";
                    break;

                case 15:
                    label = "P";
                    break;

                case 16:
                    label = "Q";
                    break;

                case 17:
                    label = "R";
                    break;

                case 18:
                    label = "S";
                    break;

                case 19:
                    label = "T";
                    break;

            }
            return label;

        }

        private Label selectLabel(int index)
        {
           Label label = new Label();

            switch(index)
            { 

                case 0: 
                    label= seatA;
                    break;

                case 1: 
                    label= seatB;
                    break;

                case 2: 
                    label= seatC;
                    break;

                case 3: 
                    label= seatD;
                    break;

                case 4: 
                    label= seatE;
                    break;

                case 5: 
                    label= seatF;
                    break;

                case 6: 
                    label= seatG;
                    break;

                case 7: 
                    label= seatH;
                    break;

                case 8: 
                    label= seatI;
                    break;

                case 9: 
                    label= seatJ;
                    break;

                case 10: 
                    label= seatK;
                    break;

                case 11: 
                    label= seatL;
                    break;

                case 12: 
                    label= seatM;
                    break;

                case 13: 
                    label= seatN;
                    break;

                case 14: 
                    label= seatO;
                    break;

                case 15: 
                    label= seatP;
                    break;

                case 16: 
                    label= seatQ;
                    break;

                case 17: 
                    label= seatR;
                    break;

                case 18: 
                    label= seatS;
                    break;

                case 19: 
                    label= seatT;
                    break;

            }
            return label;
        }

        private void seat_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            for (int index = 0; index < 20; index++)
            {
                if (seats[index].isBooked)
                {
                    Label label = selectLabel(index);
                    label.ToolTip = "Reserved By " + seats[index].passangerFirstName + seats[index].passangerLastName;

                }

                else {
                    Label label = selectLabel(index);
                    label.ToolTip = "Not Reserved";
                }
            }
        
        }

        private void clearNumberedSeat_Click(object sender, RoutedEventArgs e)
        {
            if(clearSeatSelector.SelectedIndex>1)
            {
                phoneTextField.Text = (clearSeatSelector.SelectedIndex-1).ToString();
                error.Visibility = Visibility.Collapsed;
                seats[clearSeatSelector.SelectedIndex - 1].isBooked = false;
                seats[clearSeatSelector.SelectedIndex - 1].passangerFirstName = "Not ";
                seats[clearSeatSelector.SelectedIndex - 1].passangerLastName = "Rerserved";
                updateSeats();
            }
            else
            {

                error.Visibility = Visibility.Visible;
                error.Content = "Please Select a seat...";
            }
            
        }

        private void clearSeats_Click(object sender, RoutedEventArgs e)
        {
            initalizeSeats(false);

            //label.Content = "Hi, Choose Your Seat from below";
            label.Background = (Brush)new BrushConverter().ConvertFromString("#FFF");
        }
        
        private void seatSelector_Selected(object sender, RoutedEventArgs e)
        {
            phoneTextField.Text = seatSelector.Text;
        }
        
        private void reserveSeat_Click(object sender, RoutedEventArgs e)
        {
            //resultLable.Content = "Button Clicked";
            if (seatSelector.SelectedIndex > 0)
            {
                error.Visibility = Visibility.Collapsed;
                if (!IsALLSelected && IsDetailsValids)
                {


                    if (seats[seatSelector.SelectedIndex - 1].isBooked)
                    {
                        success.Visibility = Visibility.Hidden;
                        error.Visibility = Visibility.Visible;
                        error.Content = "Sorry You cannot book that seat... It is reserved";
                    }
                    else
                    {
                        var travellersList  = new List<Seat>();
                        seats[seatSelector.SelectedIndex - 1].isBooked = true;
                        seats[seatSelector.SelectedIndex - 1].passangerFirstName = fNameTextField.Text;
                        seats[seatSelector.SelectedIndex - 1].passangerLastName = lNameTextField.Text;
                        seats[seatSelector.SelectedIndex - 1].PassangerMobileNumber = phoneTextField.Text;
                        //travellersList.Add(seats[seatSelector.SelectedIndex - 1]);

                        // XML Serialization 

                        List<int> emptySeats = new List<int>();

                        for (var i = 0; i< seats.Length; i++)
                        {
                            if (seats[i].isBooked)
                            {
                                travellersList.Add(seats[i]);
                            }
                            else
                            {
                                emptySeats.Add(i);
                            }
                        }

                        var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
                        using(var writer = new StreamWriter(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleData.xml"))
                        {
                            XmlSerializer.Serialize(writer, travellersList);
                        }

                        var XmlSerializerInt = new XmlSerializer(typeof(List<int>));
                        using (var writer = new StreamWriter(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleDataInt.xml"))
                        {
                            XmlSerializerInt.Serialize(writer, emptySeats);
                        }

                        updateSeats();

                        error.Visibility = Visibility.Hidden;
                        success.Visibility = Visibility.Visible;
                        showList();

                    }
                }
                else
                {
                    success.Visibility = Visibility.Hidden;
                    error.Visibility = Visibility.Visible;
                    error.Content = "Either all seats are booked or the details you entered are not valid";
                }
            }
            else
            {

                error.Visibility = Visibility.Visible;
                error.Content = "Please Select a seat...";
            }
               
            
        }

        private void showList()
        {
            /*for (int index = 0; index < 20; index++)
            {
                if (seats[index].isReserved)
                {
                    listing.Text = listing.Text + index + " Reserved By : " + seats[index].personFirstName + " " + seats[index].personLastName + "\n";
                }
            }*/

            // XML Deserializtion
            listing.Text = "";
            var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
            List<Seat> visitors = new List<Seat>();

            using (var reader = new StreamReader(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleData.xml"))
            {
                visitors = (List<Seat>)XmlSerializer.Deserialize(reader);
                // Console.WriteLine(travellers.ToString());
                if(visitors != null)
                {
                    for (int index = 0; index < visitors.Count; index++)
                    {
                        listing.Text = listing.Text + index + " Booked By : " + visitors[index].passangerFirstName + " " + visitors[index].passangerLastName + "\n";
                    }
                }
                else
                {
                    listing.Text = "No bookings yet";
                }
            }

            
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            listing.Text = "";
            var XmlSerializer = new XmlSerializer(typeof(List<Seat>));
            List<Seat> Visitors = new List<Seat>();

            using (var reader = new StreamReader(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleData.xml"))
            {
                Visitors = (List<Seat>)XmlSerializer.Deserialize(reader);
                
            }

           


           // resultLable.Content = listFilter.SelectedIndex;

            List<Seat> SortedList = new List<Seat>();

            if(listFilter.SelectedIndex == 0)
            {
                SortedList = Visitors.OrderBy(obj=> obj.passangerFirstName).Reverse().ToList();
            }else if(listFilter.SelectedIndex == 2)
            {
                SortedList = Visitors.OrderBy(obj => obj.passangerFirstName.Length).ToList();
            }else if(listFilter.SelectedIndex == 1)
            {

                var xmlSerializerInt = new XmlSerializer(typeof(List<int>));
                //List<Seat> travellers = new List<Seat>();

                using (var reader = new StreamReader(@""+ System.AppDomain.CurrentDomain.BaseDirectory+"\\SampleDataInt.xml"))
                {
                    var vacantSeats = (List<int>)xmlSerializerInt.Deserialize(reader);

                    List<int> DecendOrder = vacantSeats.OrderBy(obj => obj).Reverse().ToList();


                    for (int index = 0; index < DecendOrder.Count; index++)
                    {
                        //Label label = selectLabel(index);
                        int vacantListIndex = DecendOrder.ElementAt(index);

                        listing.Text = listing.Text+ "Seat : " + seatName(vacantListIndex) + "\n";
                    }
                }

            }


            if (SortedList != null)
            {
                for (int index = 0; index < SortedList.Count; index++)
                {
                    listing.Text = listing.Text + index + " Booked By : " + SortedList[index].passangerFirstName + " " + SortedList[index].passangerLastName + "\n";
                }
            }
            else
            {
                listing.Text = "No bookings yet";
            }

            /*
                if (travellers != null)
                {
                    for (int index = 0; index < travellers.Count; index++)
                    {
                        listing.Text = listing.Text + index + " Booked By : " + travellers[index].personFirstName + " " + travellers[index].personLastName + "\n";
                    }
                }
                else
                {
                    listing.Text = "No bookings yet";
                }
             
             */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            initalizeSeats(true);
            IsALLSelected = true;
            label.Content = "Sorry, All seats are full !!!";
            label.Background = (Brush)new BrushConverter().ConvertFromString("#FF856B");
        }

        private void fNameTextField_LostFocus(object sender, RoutedEventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z][a-zA-Z][a-zA-Z]+$");

            if (!regexItem.IsMatch(fNameTextField.Text))
            {
                IsDetailsValids = false;
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "First name cannot be null, cannot contain spaces,\nspecial characters or numbers\n and it should be 3 characters long ";
            }
            else {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
        }

        private void lNameTextField_LostFocus(object sender, RoutedEventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z][a-zA-Z][a-zA-Z]+$");

            if (!regexItem.IsMatch(lNameTextField.Text))
            {
                IsDetailsValids = false; 
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "Last name cannot be null, cannot contain spaces,\nspecial characters or numbers\n and it should be 3 characters long ";
            }
            else
            {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
        }

        private void phoneTextField_LostFocus(object sender, RoutedEventArgs e)
        {
            
         

            if (phoneTextField.Text.Length == 10 && !phoneTextField.Text.Any(x => char.IsLetter(x)) && !phoneTextField.Text.Any(x => char.IsSymbol(x)))
            {
                IsDetailsValids = true;
                textBoxError.Visibility = Visibility.Collapsed;
            }
           else
            {
                IsDetailsValids = false;
                textBoxError.Visibility = Visibility.Visible;
                textBoxError.Content = "Invalid Phone Number !!";
            }
    

        }

        private void seatSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
