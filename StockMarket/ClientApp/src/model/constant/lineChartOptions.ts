export const lineChartOptions : any = {
    responsive: true
    ,
    scales: {
        xAxes: [{
            type: "time"
            , scaleLabel: {
                display: true,
                labelString: 'Date'
            }
        }],
        yAxes: [{
            scaleLabel: {
                display: true,
                labelString: 'value'
            }
        }]
    }
    ,pan: {
        // Boolean to enable panning
        enabled: true,

        // Panning directions. Remove the appropriate direction to disable 
        // Eg. 'y' would only allow panning in the y direction
        mode: 'xy'
    },

    // Container for zoom options
    zoom: {
        // Boolean to enable zooming
        enabled: true,

        // Zooming directions. Remove the appropriate direction to disable 
        // Eg. 'y' would only allow zooming in the y direction
        mode: 'xy',
    }
    ,elements: {
        point:{
            radius: 0
        }
    }
};



