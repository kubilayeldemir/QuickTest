<template>
  <div>
    <div class="card mb-4 rounded-3 shadow-sm">
      <div class="card-header py-3">
        <div class="d-flex flex-row">
          <status-indicator :pulse="true" :status="TestCase.active ? 'positive':'negative'" class="mt-3"/>
          <h4 class="p-2 my-0 fw-normal">{{ this.TestCase.testName }}</h4>
        </div>
      </div>
      <div class="card-body">
        <ul class="list-unstyled mt-3 mb-4">
          <li class="text-truncate">{{ TestCase.websiteAddress }}</li>
          <li>Timing: {{ TestCase.cycleTimingByMinutes }}</li>
          <li>Critical:
            <status-indicator :status="TestCase.critical ? 'positive':'negative'"/>
          </li>
          <li>{{ TestCase.steps.length }} Steps</li>
        </ul>
        <div class="row">
          <router-link :to="{name:'ReportsPage',params:{}}">
            <button class="w-100 mb-1 btn btn-sm btn-outline-primary" type="button">Testcase</button>
          </router-link>
          <router-link :to="{name:'ReportsPage',params:{testcaseId:TestCase.id}}">
            <button class="w-100 btn btn-sm btn-outline-primary" type="button">Reports</button>
          </router-link>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import {StatusIndicator} from 'vue-status-indicator';
//<status-indicator active|positive|intermediary|negative|pulse></status-indicator>

export default {
  props: {TestCase: {}},
  components: {
    StatusIndicator
  },
  name: "TestCase"
}
</script>

<style scoped>

</style>
