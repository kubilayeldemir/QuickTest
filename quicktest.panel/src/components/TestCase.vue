<template>
<div>
  <div class="card mb-4 rounded-3 shadow-sm">
    <div class="card-header py-3">
      <div class="d-flex flex-row">
        <status-indicator class="mt-3" :status="TestCase.active ? 'positive':'negative'" :pulse="true"/>
        <h4 class="p-2 my-0 fw-normal">{{this.TestCase.testName}}</h4>
      </div>
    </div>
    <div class="card-body">
      <ul class="list-unstyled mt-3 mb-4">
        <li class="text-truncate">{{TestCase.websiteAddress}}</li>
        <li>Timing: {{TestCase.cycleTimingByMinutes}}</li>
        <li>Critical: <status-indicator :status="TestCase.critical ? 'positive':'negative'"/>
        </li>
        <li>{{TestCase.steps.length}} Steps</li>
      </ul>
      <div class="row">
      <button type="button" class="w-25 mx-auto btn btn-sm btn-outline-primary">Testcase</button>
        <button type="button" class="w-25 mx-auto btn btn-sm btn-outline-primary">Reports</button>

      </div>
    </div>
  </div>
</div>
</template>

<script>
import { StatusIndicator } from 'vue-status-indicator';
//<status-indicator active|positive|intermediary|negative|pulse></status-indicator>

export default {
  props:{TestCase:{}},
  components:{
    StatusIndicator
  },
  name: "TestCase"
}
</script>

<style scoped>

</style>
