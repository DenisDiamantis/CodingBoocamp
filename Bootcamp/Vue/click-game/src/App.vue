<template>
  <div>
    <h1>Click faster than your shadow</h1>
    <button @click="delay">Click to Play</button>

    <div v-if="showBox">
      <GamePlay />
    </div>
  </div>
</template>
<script>
import GamePlay from './components/GamePlay.vue';
export default {

  name: 'App',
  data() {
    return {
      showBox: false
    }
  },
  methods: {
    delay() {
      setTimeout(() => { this.showBox = true; }, 2 * 1000 + 1000 * Math.random(5));
    }
  },
  components: {
    GamePlay
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
