<script>
export default {
  name: "TestCasePage",
  props: {
    testcase: Object
  }
}
</script>

<template>
  <div class="container mt-5 ms-5">
    <p>TestName: {{ testcase.testName }}</p>
    <p>Website Name: {{ testcase.websiteAddress }}</p>
    <p>Test Cycle: {{ testcase.cycleTimingByMinutes }}</p>
    <p>Is Active? {{ testcase.active }}</p>
    <p>Is Critical Testcase? {{ testcase.critical }}</p>
    <ol>
      <li v-for="step in testcase.steps" :key="step.id">
        <p>Action: {{ step.action }}</p>
        <p>Action Text: {{ step.actionText }}</p>
        <p>Find By: {{ step.by }}</p>
        <p>elementAddress: {{ step.elementAddress }}</p>
        <p>stepNumber: {{ step.stepNumber }}</p>
      </li>
    </ol>


  </div>
</template>


<style scoped>

</style>
