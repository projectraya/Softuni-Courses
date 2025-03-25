const { expect } = require("chai");
const provider = require("../MusicProvider/musicProvider");
const playSong = require("../MusicProvider/musicProvider");

describe("Music Provider Tests", () => {
    
    it("should return undefined for a song not in a collection", () => {
        expect(playSong(['Imagine', 'One', 'Hey Jude', 'Billie Jean'], ['Hey Jude'], 'Respect'))
        .to.equal(undefined);
    })
});

