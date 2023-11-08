const app = Vue.createApp({
    data() {
        return {
            url: 'https://www.groundofcode.gr',
            showBooks: true,
            books: [
                { title: 'name of the wind', author: "patrick rothfuss", img: 'assets/1.jpg', isFav: true },
                { title: 'the way of kings', author: "brandon sunderson", img: 'assets/2.jpg', isFav: false },
                { title: 'the final empire', author: "brandon sunderson", img: 'assets/3.jpg', isFav: true }
            ],
            // title: 'The Way of Kings',
            // author: 'Brandon Sanderson',
            // age: 45,
            // x: 0,
            // y: 0
        }
    },
    methods: {

        toggleShowBooks() {
            this.showBooks = !this.showBooks;
        },
        toggleFavourite(book) {
            book.isFav = !book.isFav;

        },



        // changeTitle(title) {
        //     this.title = title
        // },
        // handleEvent() {
        //     console.log("you double clicked me")
        // },
        // handleMouseMove(e) {
        //     this.x = e.offsetX
        //     this.y = e.offsetY
        // },
        // handleMouseOver(e, data) {
        //     console.log(e)
        //     console.log(data)
        // }
    },
    computed: {
        filteredBooks() {
            return this.books.filter((book) => book.isFav)
        }
    }
})

app.mount('#app')