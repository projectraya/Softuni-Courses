class Request{
    
    constructor(method, uri, version, message){

        this.method = method,
        this.uri = uri,
        this.version = version,
        this.message = message
        this.response = undefined,
        this.fulfilled = false;
    }
}

let myData = new Request('GET', 'https://google.com', 'HTTP/1.1', '')
console.log(myData);