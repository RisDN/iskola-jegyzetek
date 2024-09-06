<script setup>
defineProps(["brand", "model", "color", "price", "year"])

</script>

<template>

    <tr>
        <td>{{ brand }}</td> 
        <td>{{ model }}</td> 
        <td :style="{backgroundColor: color}"></td>
        <td>{{ price }}</td>
        <td>{{ year }}</td>
    </tr>

</template>

