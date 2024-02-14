
/**** INI ****/
DateTime dateTime = DateTime.Now;

// First format: dd-MM-yyyy hh:mm:ss
string formatedDate01 = String.Format("First format: {0:dd-MM-yyyy HH:mm:ss} \n", dateTime);
Console.WriteLine(formatedDate01);


// Second format: Saturday of month ****** yyyy
string formatedDate02 = String.Format("Second format: {0:dddd} of month {0:MMMM yyyy} \n", dateTime);
//                              OR    "Second format: {0:dddd 'of month' MMMM yyyy} \n"
Console.WriteLine(formatedDate02);


/*
 * Third format: 
 *      Day Saturday
 *      Month ******
 *      Year yyyy
 */
string formatedDate03 = String.Format("Third format: \n Day {0:dddd} \n Month {0:MMMM} \n Year {0:yyyy}", dateTime);
Console.WriteLine(formatedDate03);
