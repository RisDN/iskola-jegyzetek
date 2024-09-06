<script setup>

import data from "./assets/data.json";
import Car from "./components/Car.vue"
</script>

<template>
  <main>
   
    <table>
      <tr class="asd">
        <th>Gyártó</th>
        <th>Modell</th>
        <th>Szín</th>
        <th>Ár</th>
        <th>Gyártás éve</th>
      </tr>
        <Car v-for="car in data.cars" 
          :brand="car.brand" 
          :model="car.model"
          :color="car.color"
          :price="car.price"
          :year="car.year"
          />
    </table>



  </main>
</template>

<style scoped>

</style>
