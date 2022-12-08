using WriterToFile;

var timeWriter = new TimeWriter();
var dayWriter = new DayWriter();


var writersList = new List<IWriteableToFile>
{
    timeWriter,
    dayWriter,
};

for(int i = 0; i < writersList.Count; i++)
{
    writersList[i].WriteToFile($"writer_{i}.txt");
}