fn main()
{
    bubble_sort();
}

fn bubble_sort()
{
    const arr_size : usize = 20;
    let mut arr : [i32; arr_size] = [345,3,1,4,5,6,7,8,9,10,11,12,23,124,242,5,56,7,3,2];
    

    for i in 0..arr_size - 1
    {
        
        for j in 0..arr_size - 1
        {
            let mut temp : i32 = arr[j];

            if arr[j] > arr[j + 1]
            {
                //swap them
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;

                println!("Swapped {} and {}", arr[j], arr[j+1]);
            }

        }
    }
    //end of sorting

    for int in arr
    {
        println!("{}",int)
    }


}
