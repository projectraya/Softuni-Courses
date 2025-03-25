function playSong(songsCollection, playedSongs, songName) {
    let songIndex = songsCollection.indexOf(songName);
    
    // If song doesn't exist in the collection, return undefined
    if (songIndex === -1) {
        return undefined;
    }

    // If song has been played already, return "Play On Repeat"
    if (playedSongs.includes(songName)) {
        return `Play On Repeat ${songName}`;
    }

    // Otherwise, add the song to playedSongs and return the updated list
    playedSongs.push(songName);
    return `Played songs: ${playedSongs.join(', ')}`;
}

module.exports = playSong;

//console.log(playSong(['Imagine', 'One', 'Hey Jude', 'Billie Jean'], ['Hey Jude'], 'Respect')) // undefined
// console.log(playSong(['Imagine', 'One', 'Hey Jude', 'Billie Jean', 'Respect'], ['Hey Jude'], 'Respect')) //Played songs: Hey Jude, Respect
// console.log(playSong(['Imagine', 'One', 'Hey Jude', 'Respect', 'Billie Jean'], ['Hey Jude', 'Respect'], 'Respect')) //Play On Repeat Respect