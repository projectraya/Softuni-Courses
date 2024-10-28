function journey(budget, season) {
    let destination = "";
    let accommodation = "";
    let spentAmount = 0;

    // Determine destination based on budget
    if (budget <= 100) {
        destination = "Bulgaria";
        if (season === "summer") {
            accommodation = "Camp";
            spentAmount = budget * 0.30;
        } else if (season === "winter") {
            accommodation = "Hotel";
            spentAmount = budget * 0.70;
        }
    } else if (budget <= 1000) {
        destination = "Balkans";
        if (season === "summer") {
            accommodation = "Camp";
            spentAmount = budget * 0.40;
        } else if (season === "winter") {
            accommodation = "Hotel";
            spentAmount = budget * 0.80;
        }
    } else {
        destination = "Europe";
        accommodation = "Hotel";
        spentAmount = budget * 0.90;
    }

    // Output the results
    console.log(`Somewhere in ${destination}`);
    console.log(`${accommodation} - ${spentAmount.toFixed(2)}`);
}
