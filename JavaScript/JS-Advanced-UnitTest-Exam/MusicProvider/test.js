const { expect } = require("chai");
const playSong = require("../MusicProvider/musicProvider");

describe("Music Provider Tests", () => {
    it("should return undefined for a song not in collection", () => {
        expect(playSong(['Imagine', 'One', 'Hey Jude', 'Billie Jean'], ['Hey Jude'], 'Respect'))
            .to.equal(undefined);
    });

    it("should add a song to playedSongs if it's in the collection and return updated list", () => {
        let playedSongs = ['Hey Jude'];
        let result = playSong(['Imagine', 'One', 'Hey Jude', 'Billie Jean', 'Respect'], playedSongs, 'Respect');
        expect(result).to.equal("Played songs: Hey Jude, Respect");
        expect(playedSongs).to.deep.equal(['Hey Jude', 'Respect']); // Verify mutation
    });

    it("should return 'Play On Repeat' if the song was already played", () => {
        expect(playSong(['Imagine', 'One', 'Hey Jude', 'Respect', 'Billie Jean'], ['Hey Jude', 'Respect'], 'Respect'))
            .to.equal("Play On Repeat Respect");
    });
});
