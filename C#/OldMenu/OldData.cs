// namespace OldMenufunction
// {
//     public class Menu
//     {
//         private List<double> totals = new List<double>();
//         public string Name { get; set; }

//         public void SaveTotal(double p_total){
//             totals.Add(p_total);
//             Console.WriteLine($"The result {p_total} has been succesfully added to your list of totals");
//         }

//         public void PrintTotals(){
//             for (int i = 0; i < totals.Count; i++){
//                 Console.WriteLine(totals[i]);
//             }
//         }

//         public void RemoveTotal(double p_total){
//             for (int i = 0; i < totals.Count; i++){
//                 if (totals[i] == p_total){
//                     totals.RemoveAt(i);
//                     Console.WriteLine($"The total {p_total} has been succesfully remove from your list");
//                     return;
//                 }
//             }
//             Console.WriteLine($"The total {p_total} does not exist in the list");
//         }

//         public void FindTotal(double p_total){
//             for (int i = 0; i < totals.Count; i++){
//                 if (totals[i] == p_total){
//                     Console.WriteLine($"The total {p_total} was found in your list");
//                     return;
//                 }
//             }
//             Console.WriteLine($"The total {p_total} does not exist in the list");
//         }

//         public void CalcStatement(double p_total){
//             Console.WriteLine($"The result is: {p_total}");
//             Console.WriteLine($"Would you like to save the result {p_total} to your list of totals?");
//             Console.WriteLine("Enter Y or N");
//             string toAdd = Console.ReadLine();
//             if (toAdd == "Y"){
//                 this.SaveTotal(p_total);
//             }
//         }

//     }
// }