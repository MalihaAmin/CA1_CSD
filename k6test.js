import http from 'k6/http';
import { sleep, check, group } from 'k6';

export const options = {
    vus: 10,        // Number of virtual users
    duration: '30s', // Duration of the test
};

export const homepageScenario = () => {
    let response = http.get('https://bpprojectmaliha.azurewebsites.net/');
    check(response, {
        'status is 200': (r) => r.status === 200,
    });
};

export default function () {
    // Execute the homepage scenario
    group('Homepage Scenario', () => {
        homepageScenario();
    });

    // Introduce some pacing between requests
    sleep(1);
}
