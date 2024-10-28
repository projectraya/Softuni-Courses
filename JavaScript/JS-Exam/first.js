function tvSeries(movieName, seasons, episodes, durationEpisode){
    
    seasons = Number(seasons);
    episodes = Number(episodes);
    durationEpisode = parseFloat(durationEpisode);
    durationEpisode = durationEpisode + durationEpisode * 0.2;
   
    let totalTime = seasons * episodes * durationEpisode;
    
    let extraEpisode = seasons * 10;
    totalTime += extraEpisode;
    

    console.log(`Total time needed to watch the ${movieName} series is ${totalTime} minutes.`);
}

tvSeries('Lucifer', 5, 20, 51);