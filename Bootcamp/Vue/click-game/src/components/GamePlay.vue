<template>
  <div v-if="showResult" class="showResult">
    <EndScreen :time="time" />
  </div>
  <div class="box" @click="stopTimer">
    <h3>Click me</h3>

  </div>
</template>


<script>
import EndScreen from './EndScreen.vue';

export default {
  name: "GamePlay",
  data() {
    return {
      time: 0,
      showResult: false
    };
  },
  props: {},
  methods: {
    startTimer() {
      let handle = setInterval(() => {
        if (!this.showResult) {
          this.time += 10;
        } else {
          clearInterval(handle);
        }
      }, 10);


    },
    stopTimer() {
      this.showResult = true;

    }
  },
  mounted: function () {
    this.startTimer();
  },
  components: { EndScreen }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.box {
  border: 5px solid;
  margin: auto;
  width: 20%;

  padding: 10px;
  background-color: crimson;
}



.box h3 {

  color: white;



}
</style>
