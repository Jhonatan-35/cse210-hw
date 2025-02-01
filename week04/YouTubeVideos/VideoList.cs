public class VideoList {

    private Video video1;
    private Video video2;
    private Video video3;

    private List<Video> videoList;

 
    public VideoList(){

        video1 = new Video("how to put together a rubik's cube", "WebCub", "5:01");
        video2 = new Video("learn html ", "Victor Robles Web", "46:23");
        video3 = new Video("How to manage emotions", "Pildoras of Psiologi", "4:16");

        video1.AddComment(new Comment("Taylor wilenad", "Thanks for your advice now I can put together a Ruby cube"));
        video1.AddComment(new Comment("Deysi Yugsan", "You explained it well but I think you needed to explain some important things to be able to put it together properly."));
        video1.AddComment(new Comment("Deber Davila","the best video i have seen thanks"));

        video2.AddComment(new Comment("Albert Medina", "Well honestly your video didn't help me at all."));
        video2.AddComment(new Comment("James Rice", "Well, honestly, it's was. The best video I've seen explaining HTML."));
        video2.AddComment(new Comment("Karla Bush", "I think you need to explain the best part, there were parts where you didn't."));

        video3.AddComment(new Comment("Alec Thorlakson", "interesting video Now I can handle emotions better video."));
        video3.AddComment(new Comment("Jared Pratt", "Honestly this video made me more confused than I was emotionally."));
        video3.AddComment(new Comment("Ander Smith", "Thanks for the video but it didn't help me at all."));

        videoList = new List<Video>
        {
            video1,
            video2,
            video3,
        };
    }
    public string DisplayList(){
            string result = "Videos\n";
            foreach(var video in videoList){
                result += video.DisplayVideoInfo() + "\n";
            }
            return result;
        }
}