<script>
import TestStepCreate from "@/components/TestStepCreate";

export default {
  components: {TestStepCreate},
  data() {
    return {
      testcase: {
        active: false,
        critical: false,
        cycleTimingByMinute: "",
        testName: "",
        websiteAddress: "",
        steps: []
      }
    }
  },
  name: "TestCaseCreatePage"
}
</script>

<template>
  <div class="container mt-2">
    <div class="form-group w-50">
      <label for="testname">TestCase Name:</label>
      <input id="testname" v-model="testcase.testName" class="form-control" placeholder="Name of your testcase">
    </div>
    <div class="form-group mt-2 w-50">
      <label for="website">Website Address:</label>
      <input id="website" v-model="testcase.websiteAddress" class="form-control" placeholder="Name of your testcase">
    </div>
    <div class="">
      <p class="mt-3 mb-0">Active Test?</p>
      <toggle-button v-model="testcase.active"
                     :color="{checked: '#7CFC00', unchecked: '#FF6347'}"
                     :height="30"
                     :labels="{checked: 'Active', unchecked: 'Passive'}"
                     :value="true"
                     :width="150"
                     name="active"/>
      <p class="mt-3 mb-0">Critical Test?</p>
      <toggle-button v-model="testcase.critical"
                     :color="{checked: '#FF6347', unchecked: '#7CFC00'}"
                     :height="30"
                     :labels="{checked: 'Critical', unchecked: 'Not Critical'}"
                     :value="true"
                     :width="150"
                     name="critical"/>
    </div>
    <div class="form-group col-md-4 mt-3">
      <label for="inputState">How Often your TestCase should run?</label>
      <select id="inputState" v-model="testcase.cycleTimingByMinute" class="form-control">
        <option selected value="Every10Min">Run Every 10 Minutes</option>
        <option selected value="Every30Min">Run Every 30 Minutes</option>
        <option selected value="EveryHour">Run Every Hour</option>
      </select>
    </div>
    <test-step-create></test-step-create>
  </div>
</template>

<style scoped>

</style>
